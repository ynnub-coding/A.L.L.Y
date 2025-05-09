namespace Main_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelDesign();
        }
        private Form activeForm = null;
        private void openSubForm(Form subform)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = subform;
            subform.TopLevel = false;
            subform.FormBorderStyle = FormBorderStyle.None;
            subform.Dock = DockStyle.Fill;
            pnlSubForm.Controls.Add(subform);
            pnlSubForm.Tag = subform;
            subform.BringToFront();
            subform.Show();

        }
        private void panelDesign()
        {
            pnlFocus.Visible = false;
            pnlOrganize.Visible = false;
        }
        //reusable method to hide panel.
        private void hidePanel()
        {
            if (pnlFocus.Visible == true)
            {
                pnlFocus.Visible = false;
            }
            if (pnlOrganize.Visible == true)
            {
                pnlOrganize.Visible = false;
            }
        }
        //reusable method to open side menu panels and to also close any active panel.
        private void showPanel(Panel panel)
        {
            if (panel.Visible == false)
            {
                hidePanel();
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            openSubForm(new profile());
        }
        //opens the drop-down 
        private void btnFocus_Click(object sender, EventArgs e)
        {
            showPanel(pnlFocus);
        }
            private void btnTimer_Click(object sender, EventArgs e)
            {
                openSubForm(new timer());
            }
            private void btnFlashcard_Click(object sender, EventArgs e)
            {
                openSubForm(new flashcards());
            }
        private void btnOrganize_Click(object sender, EventArgs e)
        {
            showPanel(pnlOrganize);

        }
            private void btnTasks_Click(object sender, EventArgs e)
            {
                openSubForm(new tasks());
            }
            private void btnCalendar_Click(object sender, EventArgs e)
            {
            openSubForm(new calendar());
            }

        private void btnSetting_Click(object sender, EventArgs e)
        {

        }

        

        
    }
}
