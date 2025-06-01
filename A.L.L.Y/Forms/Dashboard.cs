using Guna.UI2.WinForms;


namespace A.L.L.Y.Forms
{
    public partial class Dashboard : Form
    {
        private Dictionary<Guna2Button, Image> defaultImages;
        private Dictionary<Guna2Button, Image> activeImages;

        private string _userName;
        private int _userId;


        bool sidebarExpand;
        bool NotesExpand;
        bool subNotesMenuOpen;

        public Dashboard(string userName, int userId)
        {
            InitializeComponent();
            _userName = userName;
            _userId = userId;

            this.Load += Dashboard_Load;



        }
        //dinagdagan ko josh, eto nagbubukas ng form sa mga panel
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
            panelContents.Controls.Add(subform);
            panelContents.Tag = subform;
            subform.BringToFront();
            subform.Show();

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadControl(new Main(_userName));

            defaultImages = new Dictionary<Guna2Button, Image>
{
    { btnHome, Properties.Resources.white_home },
    { btnNotes, Properties.Resources.hollow_closed_notebook },
    { btnPlanner, Properties.Resources.hollow_calendar },
    { btnStudyLog, Properties.Resources.hollow_white_folder },
    { btnAnalytics, Properties.Resources.hollow_chart }
};

            activeImages = new Dictionary<Guna2Button, Image>
{
    { btnHome, Properties.Resources.Filled_home },
    { btnNotes, Properties.Resources.white_notebook },
    { btnPlanner, Properties.Resources.white_calendar },
    { btnStudyLog, Properties.Resources.open_folder },
    { btnAnalytics, Properties.Resources.white_chart }
};

        }
        public void LoadControl(UserControl control)
        {
            panelContents.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContents.Controls.Add(control);
        }

        private void pbxHamburger_Click(object sender, EventArgs e)
        {
            tmrSidebar.Start();
        }


        private void tmrSidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                NotesExpand = true;
                tmrNotes.Start();
                // Collapse animation
                flpSidebarContainer.Width -= 10;

                // Update TableLayoutPanel column width
                tlpMainContents.ColumnStyles[0].Width = flpSidebarContainer.Width;

                if (flpSidebarContainer.Width <= flpSidebarContainer.MinimumSize.Width)
                {
                    flpSidebarContainer.Width = flpSidebarContainer.MinimumSize.Width;
                    tlpMainContents.ColumnStyles[0].Width = flpSidebarContainer.Width;
                    sidebarExpand = false;
                    tmrSidebar.Stop();
                }
            }
            else
            {
                if (subNotesMenuOpen)
                {
                    NotesExpand = false;
                    tmrNotes.Start();
                }

                // Expand animation
                flpSidebarContainer.Width += 10;

                // Update TableLayoutPanel column width
                tlpMainContents.ColumnStyles[0].Width = flpSidebarContainer.Width;

                if (flpSidebarContainer.Width >= flpSidebarContainer.MaximumSize.Width)
                {
                    flpSidebarContainer.Width = flpSidebarContainer.MaximumSize.Width;
                    tlpMainContents.ColumnStyles[0].Width = flpSidebarContainer.Width;
                    sidebarExpand = true;
                    tmrSidebar.Stop();
                }
            }
        }



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flpSidebarContainer_Paint(object sender, PaintEventArgs e)
        {

        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tmrNotes_Tick(object sender, EventArgs e)
        {

            if (NotesExpand)
            {

                notesContainer.Height -= 10;
                if (notesContainer.Height == notesContainer.MinimumSize.Height)
                {
                    NotesExpand = false;
                    tmrNotes.Stop();
                }
            }
            else
            {

                notesContainer.Height += 10;
                if (notesContainer.Height == notesContainer.MaximumSize.Height)
                {
                    if (!sidebarExpand)
                    {
                        tmrSidebar.Start();
                    }
                    btnNotes.Image = Properties.Resources.filled_book;
                    NotesExpand = true;
                    tmrNotes.Stop();
                }
            }
        }
        private void subNotebook_Click(object sender, EventArgs e)
        {
            LoadControl(new Subject(_userId, _userName));
            subNotesMenuOpen = true;
            subFlashcards.Image = Properties.Resources.hollow_dot;
            subNotebook.Image = Properties.Resources.white_dot;
        }
        private void subFlashcards_Click(object sender, EventArgs e)
        {
            openSubForm(new FlashCards());
            subNotesMenuOpen = true;
            subNotebook.Image = Properties.Resources.hollow_dot;
            subFlashcards.Image = Properties.Resources.white_dot;


        }

        private void SetActiveButton(Guna2Button activeBtn)
        {
            foreach (var btn in defaultImages.Keys)
            {
                if (btn == activeBtn)
                {
                    btn.FillColor = ColorTranslator.FromHtml("#393839");
                    btn.Image = activeImages[btn];
                }
                else
                {
                    btn.FillColor = Color.FromArgb(33, 32, 33);
                    btn.Image = defaultImages[btn];
                    btnPlanner.ImageSize = new Size(35, 35);
                }
            }

            // Optional: reset submenu dots & flags
            subFlashcards.Image = Properties.Resources.hollow_dot;
            subNotebook.Image = Properties.Resources.hollow_dot;
            subNotesMenuOpen = false;
        }
        private void btnNotes_Click(object sender, EventArgs e)
        {
            tmrNotes.Start();
            SetActiveButton(btnNotes);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadControl(new Main(_userName));
            NotesExpand = true;
            tmrNotes.Start();
            SetActiveButton(btnHome);
        }

        private void btnPlanner_Click(object sender, EventArgs e)
        {
            NotesExpand = true;
            tmrNotes.Start();
            SetActiveButton(btnPlanner);
            SetButtonImageByMonth(btnPlanner);
        }

        private void btnStudyLog_Click(object sender, EventArgs e)
        {
            NotesExpand = true;
            tmrNotes.Start();
            SetActiveButton(btnStudyLog);
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            NotesExpand = true;
            tmrNotes.Start();
            SetActiveButton(btnAnalytics);
        }

        private void SetButtonImageByMonth(Guna2Button button)
        {
            int month = DateTime.Now.Month;
            string imagePath = Path.Combine(Application.StartupPath, "Assets", "Months", $"{month}.png");

            if (File.Exists(imagePath))
            {
                button.Image = Image.FromFile(imagePath);
                button.ImageSize = new Size(49, 49);
            }
            else
            {
                button.Image = Properties.Resources.white_calendar;
                button.ImageSize = new Size(35, 35);
            }

        }

        private void panelContents_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAnalytics_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
