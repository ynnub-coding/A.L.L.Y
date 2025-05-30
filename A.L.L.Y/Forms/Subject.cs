using A.L.L.Y.Database;
using A.L.L.Y.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace A.L.L.Y.Forms
{
    public partial class Subject : UserControl
    {
        private int currentUserId;
        private Panel selectedPanel = null;
        private string _userName;

        public Subject(int userId, string userName)
        {
            InitializeComponent();
            currentUserId = userId;
            _userName = userName;
            LoadSubjects();

            Resizer.ResizeFont(lblAdd, this, 0.05f);
          
        }

        private void LoadSubjects()
        {
            flowSubjects.Controls.Clear();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT Id, Name, Description, Logo FROM Subjects WHERE UserId = @userId";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", currentUserId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        int panelWidth = 278;   // width of a collapsed panel
                        int panelHeight = 415;  // panel height
                        int spacingX = 220;      // horizontal spacing between panels
                        int spacingY = 30;      // vertical spacing between rows
                        int leftPadding = 200;   // left margin
                        int topPadding = 20;    // top margin

                        int panelsPerRow = 3;
                        int x = leftPadding;
                        int y = topPadding;
                        int panelCount = 0;

                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["Id"]);
                            string name = reader["Name"].ToString();
                            string description = reader["Description"]?.ToString() ?? "";
                            byte[] logoData = reader["Logo"] as byte[];

                            Image logo = null;
                            if (logoData != null)
                            {
                                using (var ms = new System.IO.MemoryStream(logoData))
                                {
                                    logo = Image.FromStream(ms);
                                }
                            }

                            Point location = new Point(x, y);
                            CreateSubjectPanel(id, name, description, logo, location);

                            panelCount++;
                            if (panelCount % panelsPerRow == 0)
                            {
                                // Move to next row
                                x = leftPadding;
                                y += panelHeight + spacingY;
                            }
                            else
                            {
                                x += panelWidth + spacingX;
                            }
                        }
                    }
                }
            }
        }





        // Modified CreateSubjectPanel to accept location parameter
        private void CreateSubjectPanel(int id, string name, string description, Image logo, Point location)
        {
            var tag = new SubjectTag
            {
                Id = id,
                Name = name,
                Logo = logo
            };

            Size collapsedSize = new Size(278, 415);  // collapsed panel size
            Size expandedSize = new Size(507, 380);   // expanded panel size
            Point shiftLeftOffset = new Point(-200, 0); // shift left when expanded

            Panel subjectPanel = new Panel
            {
                BackColor = Color.Transparent,
                BackgroundImage = Properties.Resources.NotbookClosed_Default_removebg_preview,
                BackgroundImageLayout = ImageLayout.Stretch,
                Size = collapsedSize,
                Margin = new Padding(10),
                Tag = tag,
                Cursor = Cursors.Hand,
                Location = location
            };

            // Collapsed view controls
            PictureBox subjectLogo = new PictureBox
            {
                Location = new Point(72, 188),
                Size = new Size(133, 122),
                BackgroundImage = logo,
                BackgroundImageLayout = ImageLayout.Stretch,
                TabStop = false,
                Cursor = Cursors.Hand
            };

            Label lblSubject = new Label
            {
                Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic),
                Location = new Point(72, 104),
                Size = new Size(133, 51),
                Text = name,
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent,
                ForeColor = Color.Black
            };

            // Expanded view controls (hidden initially)
            Label lblDescription = new Label
            {
                Text = description,
                AutoSize = false,
                Size = new Size(200, 100),
                Location = new Point(280, 110),
                BackColor = Color.Transparent,
                ForeColor = Color.Black,
                Visible = false,
                Font = new Font("Segoe UI", 10F, FontStyle.Regular)
            };

            PictureBox expandedLogo = new PictureBox
            {
                Location = new Point(88, 106),
                Size = new Size(119, 164),
                BackgroundImage = logo,
                BackgroundImageLayout = ImageLayout.Stretch,
                TabStop = false,
                Cursor = Cursors.Hand,
                Visible = false
            };

            bool isExpanded = false;
            int clickCount = 0;
            Point originalLocation = location;

            System.Windows.Forms.Timer clickTimer = new System.Windows.Forms.Timer { Interval = 300 };
            clickTimer.Tick += (s, e) =>
            {
                clickCount = 0;
                clickTimer.Stop();
            };

            void ExpandPanel()
            {
                if (isExpanded) return;
                isExpanded = true;

                subjectPanel.Size = expandedSize;
                subjectPanel.Location = new Point(originalLocation.X + shiftLeftOffset.X, originalLocation.Y);
                subjectPanel.BackgroundImage = Properties.Resources.NotesOpen_removebg_preview;

                lblSubject.Visible = false;
                subjectLogo.Visible = false;

                lblDescription.Visible = true;
                expandedLogo.Visible = true;
            }

            void CollapsePanel()
            {
                if (!isExpanded) return;
                isExpanded = false;

                subjectPanel.Size = collapsedSize;
                subjectPanel.Location = originalLocation;
                subjectPanel.BackgroundImage = Properties.Resources.NotbookClosed_Default_removebg_preview;

                lblSubject.Visible = true;
                subjectLogo.Visible = true;

                lblDescription.Visible = false;
                expandedLogo.Visible = false;
            }


            void PanelMouseClicked(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)  // Only proceed for left click
                {
                    clickCount++;

                    if (clickCount == 1)
                    {
                        clickTimer.Start();
                        if (isExpanded)
                            CollapsePanel();
                        else
                            ExpandPanel();
                    }
                    else if (clickCount == 2)
                    {
                        clickTimer.Stop();
                        clickCount = 0;

                        Panel clickedPanel = GetParentPanel(sender);
                        if (clickedPanel != null && clickedPanel.Tag is SubjectTag tag)
                        {
                            // pass tag.Logo too

                            Dashboard dashboard = this.FindForm() as Dashboard;

                            if (dashboard != null)
                            {
                                Notes notes = new Notes(tag.Id, tag.Name, tag.Logo, _userName, currentUserId);

                                dashboard.LoadControl(notes);
                            }


                        }

                    }
                    return;
                }

            }




            // Register click events
            // Register mouse click events (only left click will trigger toggle)
            foreach (Control c in new Control[] { subjectPanel, lblSubject, subjectLogo, lblDescription, expandedLogo })
            {
                c.MouseClick += PanelMouseClicked;
            }

            // Add this right after:
            foreach (Control c in new Control[] { subjectPanel, lblSubject, subjectLogo, lblDescription, expandedLogo })
            {
                c.MouseUp += SubjectPanel_MouseUp;
            }

            // Add controls
            subjectPanel.Controls.Add(lblSubject);
            subjectPanel.Controls.Add(subjectLogo);
            subjectPanel.Controls.Add(lblDescription);
            subjectPanel.Controls.Add(expandedLogo);

            flowSubjects.Controls.Add(subjectPanel);
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (AddSubject addSubject = new AddSubject())
            {
                if (addSubject.ShowDialog() == DialogResult.OK)
                {
                    // Save new subject to database
                    using (var conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string query = "INSERT INTO Subjects (Name, Description, Logo, UserId) VALUES (@name, @desc, @logo, @userId)";
                        using (var cmd = new SQLiteCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", addSubject.SubjectName);
                            cmd.Parameters.AddWithValue("@desc", addSubject.SubjectDescription);
                            cmd.Parameters.AddWithValue("@userId", currentUserId);

                            // Convert image to byte[]
                            if (addSubject.SubjectLogo != null)
                            {
                                using (var ms = new System.IO.MemoryStream())
                                {
                                    addSubject.SubjectLogo.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                    cmd.Parameters.AddWithValue("@logo", ms.ToArray());
                                }
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@logo", DBNull.Value);
                            }

                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Refresh subjects
                    LoadSubjects();
                }
            }
        }








        // at bottom of SubjectsForm.cs
        private class SubjectTag
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public Image Logo { get; set; }   // ← new
        }

        private void SubjectPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                selectedPanel = GetParentPanel(sender);
                if (selectedPanel != null)
                {
                    cmSubjects.Show(Cursor.Position);
                }
            }
        }

        private Panel GetParentPanel(object sender)
        {
            Control ctrl = sender as Control;
            while (ctrl != null && !(ctrl is Panel))
                ctrl = ctrl.Parent;
            return ctrl as Panel;
        }

        private void deleteSubjectMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedPanel != null && selectedPanel.Tag is SubjectTag tag)
            {
                string subjectName = tag.Name;

                var result = MessageBox.Show($"Delete subject '{subjectName}'?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes) return;

                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM Subjects WHERE Id = @id AND UserId = @userId";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", tag.Id);
                        cmd.Parameters.AddWithValue("@userId", currentUserId);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Instead of manually removing and disposing the panel, refresh everything:
                LoadSubjects();  // Refreshes the flow layout and recalculates all locations
                selectedPanel = null;
            }
        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            using (AddSubject addSubject = new AddSubject())
            {
                if (addSubject.ShowDialog() == DialogResult.OK)
                {
                    // Save new subject to database
                    using (var conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string query = "INSERT INTO Subjects (Name, Description, Logo, UserId) VALUES (@name, @desc, @logo, @userId)";
                        using (var cmd = new SQLiteCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", addSubject.SubjectName);
                            cmd.Parameters.AddWithValue("@desc", addSubject.SubjectDescription);
                            cmd.Parameters.AddWithValue("@userId", currentUserId);

                            // Convert image to byte[]
                            if (addSubject.SubjectLogo != null)
                            {
                                using (var ms = new System.IO.MemoryStream())
                                {
                                    addSubject.SubjectLogo.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                    cmd.Parameters.AddWithValue("@logo", ms.ToArray());
                                }
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@logo", DBNull.Value);
                            }

                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Refresh subjects
                    LoadSubjects();
                }
            }
        }

        private void flowSubjects_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flpSidebarContainer_Paint(object sender, PaintEventArgs e)
        {

        }





        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tbpSubjectFormLayout_Paint(object sender, PaintEventArgs e)
        {

        }







        private void flowSubjects_Paint_1(object sender, PaintEventArgs e)
        {

        }


        private void flowSubjects_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void flowSubjects_Paint_3(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void flowSubjects_Paint_4(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            

           
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
           

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_3(object sender, PaintEventArgs e)
        {

        }
    }
}
