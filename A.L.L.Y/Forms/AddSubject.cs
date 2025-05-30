using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace A.L.L.Y.Forms
{
    public partial class AddSubject : Form
    {

        public string SubjectName => txtSubjectName.Text;
        public string SubjectDescription => txtSubjectDescription.Text;
        public Image SubjectLogo => pbxLogo.Image;
        public AddSubject()
        {
            InitializeComponent();
        }

        private void lblSubjectDescription_Click(object sender, EventArgs e)
        {

        }

        private void AddSubject_Load(object sender, EventArgs e)
        {

        }

        private void btnChooseLogo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.png;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbxLogo.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void pbxLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveSubject_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSubjectName.Text))
            {
                MessageBox.Show("Please enter a subject name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
