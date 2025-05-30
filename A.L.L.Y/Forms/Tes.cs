using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A.L.L.Y.Forms
{
    public partial class Tes : Form
    {
        public Tes()
        {
            InitializeComponent();
            // Attach MouseHover to child controls
            panel5.MouseHover += panel4_MouseHover;
            label4.MouseHover += panel4_MouseHover;

            Tes_Load(); // Load the test panel content
        }


        private void Tes_Load()
        {
            var panel = CreateCustomPanel(
        "Test Subject Description",
        Properties.Resources.Screenshot__3_,
        (s, ev) => MessageBox.Show("You clicked the image!")
    );

            testPanel.Controls.Add(panel); // Or any other panel
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel4_MouseEnter(object sender, EventArgs e)
        {

        }
        private void panel4_MouseHover(object sender, EventArgs e)
        {

            panel4.Size = new Size(507, 380);
            panel4.BackgroundImage = Properties.Resources.NotesOpen_removebg_preview;
            panel4.Location = new Point(103, 439);
            panel5.Visible = true;
            label4.Visible = true;


        }
        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.Size = new Size(278, 415);
            panel4.BackgroundImage = Properties.Resources.NotbookClosed_Default_removebg_preview;
            panel4.Location = new Point(332, 439);

            panel5.Visible = false;
            label4.Visible = false;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {


        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void testPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private Panel CreateCustomPanel(string labelText, Image picture, EventHandler onClick)
        {
            // Main Panel
            Panel panel = new Panel
            {
                BackColor = Color.Transparent,
                BackgroundImage = Properties.Resources.NotesOpen_removebg_preview,
                BackgroundImageLayout = ImageLayout.Stretch,
                ForeColor = Color.Black,
                Size = new Size(507, 380),
                Margin = new Padding(10) // optional for spacing in FlowLayoutPanel
            };

            // PictureBox (acts like pbxTemplatePanel)
            PictureBox pbx = new PictureBox
            {
                BackgroundImage = picture,
                BackgroundImageLayout = ImageLayout.Stretch,
                Location = new Point(88, 106),
                Size = new Size(119, 164),
                TabStop = false,
                Cursor = Cursors.Hand
            };

            if (onClick != null)
                pbx.Click += onClick;

            // Label (acts like lblTemplatePanel)
            Label lbl = new Label
            {
                BackColor = Color.Transparent,
                Text = labelText,
                Location = new Point(283, 117),
                Size = new Size(171, 173),
                ForeColor = Color.Black
            };

            // Add controls to the panel
            panel.Controls.Add(lbl);
            panel.Controls.Add(pbx);

            return panel;
        }

        private void TemplatePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void subjectPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
