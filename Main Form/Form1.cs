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
        }
        //one time use to hide every panel
        private void hidePanel()
        {
            if (pnlFocus.Visible == true)
            {
                pnlFocus.Visible = false;
            }
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnFocus_Click(object sender, EventArgs e)
        {
            if (pnlFocus.Visible == false)
            {
                pnlFocus.Visible = true;
            }
            else
            {
                pnlFocus.Visible = false;
            }
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
    }
}
