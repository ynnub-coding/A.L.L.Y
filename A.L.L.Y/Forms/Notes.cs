using A.L.L.Y.Database;
using A.L.L.Y.Models;
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
    public partial class Notes : UserControl
    {
        private int subjectId;
        private Image subjectImage;
        private int? currentNoteId = null;
        private string _userName;
        private int _userId;
        public Notes(int subjectId, string subjectName, Image subjectImage, string userName, int userId)
        {
            InitializeComponent();
            _userName = userName;
            _userId = userId;
            this.subjectId = subjectId;
            this.subjectImage = subjectImage;

            this.Text = $"Notes - {subjectName}";
            pbxLogo.Image = subjectImage;

            LoadNotes(subjectId);


            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            lstNotes.MouseDown += lstNotes_MouseDown;
        }

        private void LoadNotes(int subjectId)
        {
            lstNotes.Items.Clear();

            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                string selectQuery = "SELECT NoteId, Title, CreatedAt FROM Notes WHERE SubjectId = @SubjectId ORDER BY CreatedAt DESC";

                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@SubjectId", subjectId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0); // NoteId column
                            string title = reader.GetString(1);
                            // Parse CreatedAt since it's stored as TEXT
                            DateTime createdAt = DateTime.Parse(reader.GetString(2));

                            string displayText = $"{title} ({createdAt.ToShortDateString()})";

                            lstNotes.Items.Add(new NoteListItem { Id = id, DisplayText = displayText });
                        }
                    }
                }
            }

        }
        private void lstNotes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = lstNotes.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                {
                    lstNotes.SelectedIndex = index;
                    // Show context menu at mouse position
                    contextMenuNotes.Show(lstNotes, e.Location);
                }
                else
                {
                    lstNotes.ClearSelected();
                }
            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text.Trim()) || string.IsNullOrEmpty(richtxtNotes.Text.Trim()))
            {
                MessageBox.Show("Title and content cannot be empty.");
                return;
            }

            if (currentNoteId.HasValue)
            {
                // Update existing note
                UpdateNoteInDatabase(new Note
                {
                    NoteId = currentNoteId.Value,
                    SubjectId = this.subjectId,
                    Title = txtTitle.Text.Trim(),
                    Content = richtxtNotes.Text.Trim(),
                    CreatedAt = DateTime.Now // or keep original date if you want
                });
            }
            else
            {
                // Insert new note
                SaveNoteToDatabase(new Note
                {
                    SubjectId = this.subjectId,
                    Title = txtTitle.Text.Trim(),
                    Content = richtxtNotes.Text.Trim(),
                    CreatedAt = DateTime.Now
                });
            }

            LoadNotes(subjectId);
            txtTitle.Clear();
            richtxtNotes.Clear();
            currentNoteId = null;

            MessageBox.Show("Note saved successfully!");
        }

        private void UpdateNoteInDatabase(Note note)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                string updateQuery = @"
            UPDATE Notes SET Title = @Title, Content = @Content, CreatedAt = @CreatedAt
            WHERE NoteId = @NoteId;
        ";

                using (var command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Title", note.Title);
                    command.Parameters.AddWithValue("@Content", note.Content);
                    command.Parameters.AddWithValue("@CreatedAt", note.CreatedAt.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.Parameters.AddWithValue("@NoteId", note.NoteId);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void SaveNoteToDatabase(Note note)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                string insertQuery = @"
                    INSERT INTO Notes (SubjectId, Title, Content, CreatedAt)
                    VALUES (@SubjectId, @Title, @Content, @CreatedAt);
                ";

                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@SubjectId", note.SubjectId);
                    command.Parameters.AddWithValue("@Title", note.Title);
                    command.Parameters.AddWithValue("@Content", note.Content);
                    command.Parameters.AddWithValue("@CreatedAt", note.CreatedAt.ToString("yyyy-MM-dd HH:mm:ss"));

                    command.ExecuteNonQuery();
                }
            }
        }

        private void lstNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNotes.SelectedItem is NoteListItem selectedNote)
            {
                LoadNoteContent(selectedNote.Id);
            }
        }

        private void LoadNoteContent(int noteId)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                string query = "SELECT Title, Content FROM Notes WHERE NoteId = @Id";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", noteId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtTitle.Text = reader.GetString(0);
                            richtxtNotes.Text = reader.GetString(1);
                        }
                    }
                }
            }
            currentNoteId = noteId;

        }


        // Sidebar toggle timer event
        private void tmrSidebar_Tick(object sender, EventArgs e)
        {

        }



        private class NoteListItem
        {
            public int Id { get; set; }
            public string DisplayText { get; set; }

            public override string ToString()
            {
                return DisplayText;
            }
        }

        private void flpSidebarContainer_Paint(object sender, PaintEventArgs e)
        {
            // You can leave this empty if you don't want to do anything here
        }

        private void lblAddNote_Click(object sender, EventArgs e)
        {
            // Add code here if you want to handle this click event
        }

        private void NoteTaking_Load(object sender, EventArgs e)
        {
            // This runs when the form loads - you can add code here or leave empty
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Handle pictureBox1 click if needed
        }

        private void richtxtNotes_TextChanged(object sender, EventArgs e)
        {
            // Handle text changed event here if needed
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Handle painting event here if needed
        }


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstNotes.SelectedItem is NoteListItem selectedNote)
            {
                var confirmResult = MessageBox.Show(
                    "Are you sure you want to delete this note?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    using (var connection = DatabaseHelper.GetConnection())
                    {
                        connection.Open();

                        string deleteQuery = "DELETE FROM Notes WHERE NoteId = @NoteId";

                        using (var command = new SQLiteCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@NoteId", selectedNote.Id);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Note deleted successfully!");
                    txtTitle.Clear();
                    richtxtNotes.Clear();
                    LoadNotes(subjectId);
                    currentNoteId = null;
                }
            }
            else
            {
                MessageBox.Show("Please select a note to delete.");
            }
        }







        private void tmrNotes_Tick(object sender, EventArgs e)
        {

        }

        private void pbxHamburger_Click(object sender, EventArgs e)
        {
            tmrSidebar.Start();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            tmrNotes.Start();
        }


        private void flpSidebarContainer_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void subNotebook_Click(object sender, EventArgs e)
        {

        }
    }
}
