namespace Main_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelDesign();
        }

        private void panelDesign()
        {
            pnlFocus.Visible = false;
            pnlOrganize.Visible = false;
        }
        //one time use to hide every panel
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

        }

        private void btnFocus_Click(object sender, EventArgs e)
        {
            showPanel(pnlFocus);
        }
        private void btnOrganize_Click(object sender, EventArgs e)
        {
            showPanel(pnlOrganize);

        }
        private void btnCalendar_Click(object sender, EventArgs e)
        {

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {

        }

        private void btnTimer_Click(object sender, EventArgs e)
        {

        }

        

        private void btnFlashcard_Click(object sender, EventArgs e)
        {

        }

        private void btnTasks_Click(object sender, EventArgs e)
        {

        }
    }
}
