namespace A.L.L.Y.Forms
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            tmrSidebar = new System.Windows.Forms.Timer(components);
            tmrNotes = new System.Windows.Forms.Timer(components);
            tlpMainContents = new TableLayoutPanel();
            panelContents = new Panel();
            panel9 = new Panel();
            btnAnalytics = new Guna.UI2.WinForms.Guna2Button();
            panel8 = new Panel();
            btnStudyLog = new Guna.UI2.WinForms.Guna2Button();
            panel7 = new Panel();
            btnPlanner = new Guna.UI2.WinForms.Guna2Button();
            notesContainer = new Panel();
            subFlashcards = new Guna.UI2.WinForms.Guna2Button();
            subNotebook = new Guna.UI2.WinForms.Guna2Button();
            btnNotes = new Guna.UI2.WinForms.Guna2Button();
            panel2 = new Panel();
            btnHome = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            pbxHamburger = new Krypton.Toolkit.KryptonPictureBox();
            flpSidebarContainer = new FlowLayoutPanel();
            tlpMainContents.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            notesContainer.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxHamburger).BeginInit();
            flpSidebarContainer.SuspendLayout();
            SuspendLayout();
            // 
            // tmrSidebar
            // 
            tmrSidebar.Interval = 10;
            tmrSidebar.Tick += tmrSidebar_Tick;
            // 
            // tmrNotes
            // 
            tmrNotes.Interval = 10;
            tmrNotes.Tick += tmrNotes_Tick;
            // 
            // tlpMainContents
            // 
            tlpMainContents.ColumnCount = 2;
            tlpMainContents.ColumnStyles.Add(new ColumnStyle());
            tlpMainContents.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMainContents.Controls.Add(panelContents, 1, 0);
            tlpMainContents.Dock = DockStyle.Fill;
            tlpMainContents.Location = new Point(55, 0);
            tlpMainContents.Name = "tlpMainContents";
            tlpMainContents.RowCount = 1;
            tlpMainContents.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMainContents.Size = new Size(1344, 766);
            tlpMainContents.TabIndex = 11;
            tlpMainContents.Paint += tableLayoutPanel1_Paint;
            // 
            // panelContents
            // 
            panelContents.Dock = DockStyle.Fill;
            panelContents.Location = new Point(3, 3);
            panelContents.Name = "panelContents";
            panelContents.Size = new Size(1338, 760);
            panelContents.TabIndex = 0;
            panelContents.Paint += panelContents_Paint;
            // 
            // panel9
            // 
            panel9.Controls.Add(btnAnalytics);
            panel9.Cursor = Cursors.Hand;
            panel9.Location = new Point(3, 353);
            panel9.MaximumSize = new Size(273, 57);
            panel9.MinimumSize = new Size(273, 57);
            panel9.Name = "panel9";
            panel9.Size = new Size(273, 57);
            panel9.TabIndex = 5;
            // 
            // btnAnalytics
            // 
            btnAnalytics.BackColor = Color.FromArgb(33, 32, 33);
            btnAnalytics.CustomizableEdges = customizableEdges1;
            btnAnalytics.DisabledState.BorderColor = Color.DarkGray;
            btnAnalytics.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAnalytics.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAnalytics.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAnalytics.FillColor = Color.FromArgb(33, 32, 33);
            btnAnalytics.FocusedColor = Color.FromArgb(33, 32, 33);
            btnAnalytics.Font = new Font("Palatino Linotype", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnalytics.ForeColor = Color.FromArgb(195, 195, 195);
            btnAnalytics.Image = Properties.Resources.hollow_chart;
            btnAnalytics.ImageOffset = new Point(-110, 0);
            btnAnalytics.ImageSize = new Size(45, 45);
            btnAnalytics.Location = new Point(-3, 0);
            btnAnalytics.MaximumSize = new Size(273, 37);
            btnAnalytics.MinimumSize = new Size(273, 37);
            btnAnalytics.Name = "btnAnalytics";
            btnAnalytics.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAnalytics.Size = new Size(273, 37);
            btnAnalytics.TabIndex = 9;
            btnAnalytics.Text = "        Anlaytics";
            btnAnalytics.TextAlign = HorizontalAlignment.Left;
            btnAnalytics.Click += btnAnalytics_Click;
            btnAnalytics.MouseHover += btnAnalytics_MouseHover;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnStudyLog);
            panel8.Cursor = Cursors.Hand;
            panel8.Location = new Point(3, 290);
            panel8.MaximumSize = new Size(273, 57);
            panel8.MinimumSize = new Size(273, 57);
            panel8.Name = "panel8";
            panel8.Size = new Size(273, 57);
            panel8.TabIndex = 4;
            // 
            // btnStudyLog
            // 
            btnStudyLog.BackColor = Color.FromArgb(33, 32, 33);
            btnStudyLog.CustomizableEdges = customizableEdges3;
            btnStudyLog.DisabledState.BorderColor = Color.DarkGray;
            btnStudyLog.DisabledState.CustomBorderColor = Color.DarkGray;
            btnStudyLog.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnStudyLog.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnStudyLog.FillColor = Color.FromArgb(33, 32, 33);
            btnStudyLog.FocusedColor = Color.FromArgb(33, 32, 33);
            btnStudyLog.Font = new Font("Palatino Linotype", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudyLog.ForeColor = Color.FromArgb(195, 195, 195);
            btnStudyLog.Image = Properties.Resources.hollow_white_folder;
            btnStudyLog.ImageOffset = new Point(-110, 0);
            btnStudyLog.ImageSize = new Size(45, 45);
            btnStudyLog.Location = new Point(-3, 0);
            btnStudyLog.MaximumSize = new Size(273, 37);
            btnStudyLog.MinimumSize = new Size(273, 37);
            btnStudyLog.Name = "btnStudyLog";
            btnStudyLog.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnStudyLog.Size = new Size(273, 37);
            btnStudyLog.TabIndex = 9;
            btnStudyLog.Text = "        Study Log";
            btnStudyLog.TextAlign = HorizontalAlignment.Left;
            btnStudyLog.Click += btnStudyLog_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnPlanner);
            panel7.Cursor = Cursors.Hand;
            panel7.Location = new Point(3, 227);
            panel7.MaximumSize = new Size(273, 57);
            panel7.MinimumSize = new Size(273, 57);
            panel7.Name = "panel7";
            panel7.Size = new Size(273, 57);
            panel7.TabIndex = 3;
            // 
            // btnPlanner
            // 
            btnPlanner.BackColor = Color.FromArgb(33, 32, 33);
            btnPlanner.CustomizableEdges = customizableEdges5;
            btnPlanner.DisabledState.BorderColor = Color.DarkGray;
            btnPlanner.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPlanner.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPlanner.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPlanner.FillColor = Color.FromArgb(33, 32, 33);
            btnPlanner.FocusedColor = Color.FromArgb(33, 32, 33);
            btnPlanner.Font = new Font("Palatino Linotype", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlanner.ForeColor = Color.FromArgb(195, 195, 195);
            btnPlanner.Image = Properties.Resources.hollow_calendar;
            btnPlanner.ImageOffset = new Point(-110, 0);
            btnPlanner.ImageSize = new Size(35, 35);
            btnPlanner.Location = new Point(-3, 0);
            btnPlanner.MaximumSize = new Size(273, 37);
            btnPlanner.MinimumSize = new Size(273, 37);
            btnPlanner.Name = "btnPlanner";
            btnPlanner.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnPlanner.Size = new Size(273, 37);
            btnPlanner.TabIndex = 9;
            btnPlanner.Text = "        Planner";
            btnPlanner.TextAlign = HorizontalAlignment.Left;
            btnPlanner.Click += btnPlanner_Click;
            // 
            // notesContainer
            // 
            notesContainer.BackColor = Color.FromArgb(33, 32, 33);
            notesContainer.Controls.Add(subFlashcards);
            notesContainer.Controls.Add(subNotebook);
            notesContainer.Controls.Add(btnNotes);
            notesContainer.Cursor = Cursors.Hand;
            notesContainer.Location = new Point(3, 164);
            notesContainer.MaximumSize = new Size(273, 132);
            notesContainer.MinimumSize = new Size(273, 57);
            notesContainer.Name = "notesContainer";
            notesContainer.Size = new Size(273, 57);
            notesContainer.TabIndex = 2;
            // 
            // subFlashcards
            // 
            subFlashcards.BackColor = Color.FromArgb(33, 32, 33);
            subFlashcards.CustomizableEdges = customizableEdges7;
            subFlashcards.DisabledState.BorderColor = Color.DarkGray;
            subFlashcards.DisabledState.CustomBorderColor = Color.DarkGray;
            subFlashcards.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            subFlashcards.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            subFlashcards.FillColor = Color.FromArgb(33, 32, 33);
            subFlashcards.FocusedColor = Color.FromArgb(33, 32, 33);
            subFlashcards.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subFlashcards.ForeColor = Color.FromArgb(195, 195, 195);
            subFlashcards.Image = Properties.Resources.hollow_dot;
            subFlashcards.ImageOffset = new Point(-80, 0);
            subFlashcards.ImageSize = new Size(25, 25);
            subFlashcards.Location = new Point(-3, 86);
            subFlashcards.Name = "subFlashcards";
            subFlashcards.ShadowDecoration.CustomizableEdges = customizableEdges8;
            subFlashcards.Size = new Size(273, 37);
            subFlashcards.TabIndex = 11;
            subFlashcards.Text = "                Flashcards";
            subFlashcards.TextAlign = HorizontalAlignment.Left;
            subFlashcards.Click += subFlashcards_Click;
            // 
            // subNotebook
            // 
            subNotebook.BackColor = Color.FromArgb(33, 32, 33);
            subNotebook.CustomizableEdges = customizableEdges9;
            subNotebook.DisabledState.BorderColor = Color.DarkGray;
            subNotebook.DisabledState.CustomBorderColor = Color.DarkGray;
            subNotebook.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            subNotebook.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            subNotebook.FillColor = Color.FromArgb(33, 32, 33);
            subNotebook.FocusedColor = Color.FromArgb(33, 32, 33);
            subNotebook.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subNotebook.ForeColor = Color.FromArgb(195, 195, 195);
            subNotebook.Image = Properties.Resources.hollow_dot;
            subNotebook.ImageOffset = new Point(-80, 0);
            subNotebook.ImageSize = new Size(25, 25);
            subNotebook.Location = new Point(-3, 56);
            subNotebook.Name = "subNotebook";
            subNotebook.ShadowDecoration.CustomizableEdges = customizableEdges10;
            subNotebook.Size = new Size(273, 37);
            subNotebook.TabIndex = 10;
            subNotebook.Text = "                Notebook";
            subNotebook.TextAlign = HorizontalAlignment.Left;
            subNotebook.Click += subNotebook_Click;
            // 
            // btnNotes
            // 
            btnNotes.BackColor = Color.FromArgb(33, 32, 33);
            btnNotes.CustomizableEdges = customizableEdges11;
            btnNotes.DisabledState.BorderColor = Color.DarkGray;
            btnNotes.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNotes.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNotes.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNotes.FillColor = Color.FromArgb(33, 32, 33);
            btnNotes.FocusedColor = Color.FromArgb(33, 32, 33);
            btnNotes.Font = new Font("Palatino Linotype", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNotes.ForeColor = Color.FromArgb(195, 195, 195);
            btnNotes.Image = Properties.Resources.hollow_closed_notebook;
            btnNotes.ImageOffset = new Point(-110, 0);
            btnNotes.ImageSize = new Size(40, 40);
            btnNotes.Location = new Point(-3, 3);
            btnNotes.MaximumSize = new Size(273, 37);
            btnNotes.MinimumSize = new Size(273, 37);
            btnNotes.Name = "btnNotes";
            btnNotes.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnNotes.Size = new Size(273, 37);
            btnNotes.TabIndex = 9;
            btnNotes.Text = "        Notes";
            btnNotes.TextAlign = HorizontalAlignment.Left;
            btnNotes.Click += btnNotes_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnHome);
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(3, 101);
            panel2.MaximumSize = new Size(273, 57);
            panel2.MinimumSize = new Size(273, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 57);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(33, 32, 33);
            btnHome.CustomizableEdges = customizableEdges13;
            btnHome.DisabledState.BorderColor = Color.DarkGray;
            btnHome.DisabledState.CustomBorderColor = Color.DarkGray;
            btnHome.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnHome.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnHome.FillColor = Color.FromArgb(33, 32, 33);
            btnHome.FocusedColor = Color.FromArgb(33, 32, 33);
            btnHome.Font = new Font("Palatino Linotype", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.FromArgb(195, 195, 195);
            btnHome.Image = Properties.Resources.Filled_home;
            btnHome.ImageOffset = new Point(-110, 0);
            btnHome.ImageSize = new Size(35, 35);
            btnHome.Location = new Point(-3, 0);
            btnHome.MaximumSize = new Size(273, 37);
            btnHome.MinimumSize = new Size(273, 37);
            btnHome.Name = "btnHome";
            btnHome.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnHome.Size = new Size(273, 37);
            btnHome.TabIndex = 9;
            btnHome.Text = "        Home";
            btnHome.TextAlign = HorizontalAlignment.Left;
            btnHome.Click += btnHome_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pbxHamburger);
            panel1.Location = new Point(3, 3);
            panel1.MaximumSize = new Size(273, 92);
            panel1.MinimumSize = new Size(273, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 92);
            panel1.TabIndex = 0;
            // 
            // pbxHamburger
            // 
            pbxHamburger.Cursor = Cursors.Hand;
            pbxHamburger.Image = Properties.Resources.hamburger;
            pbxHamburger.Location = new Point(9, 9);
            pbxHamburger.MaximumSize = new Size(35, 35);
            pbxHamburger.MinimumSize = new Size(35, 35);
            pbxHamburger.Name = "pbxHamburger";
            pbxHamburger.Size = new Size(35, 35);
            pbxHamburger.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxHamburger.TabIndex = 0;
            pbxHamburger.TabStop = false;
            pbxHamburger.Click += pbxHamburger_Click;
            // 
            // flpSidebarContainer
            // 
            flpSidebarContainer.BackColor = Color.FromArgb(33, 32, 33);
            flpSidebarContainer.Controls.Add(panel1);
            flpSidebarContainer.Controls.Add(panel2);
            flpSidebarContainer.Controls.Add(notesContainer);
            flpSidebarContainer.Controls.Add(panel7);
            flpSidebarContainer.Controls.Add(panel8);
            flpSidebarContainer.Controls.Add(panel9);
            flpSidebarContainer.Dock = DockStyle.Left;
            flpSidebarContainer.Location = new Point(0, 0);
            flpSidebarContainer.MaximumSize = new Size(276, 9999);
            flpSidebarContainer.MinimumSize = new Size(55, 9999);
            flpSidebarContainer.Name = "flpSidebarContainer";
            flpSidebarContainer.Size = new Size(55, 9999);
            flpSidebarContainer.TabIndex = 10;
            flpSidebarContainer.Paint += flpSidebarContainer_Paint;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1399, 766);
            Controls.Add(tlpMainContents);
            Controls.Add(flpSidebarContainer);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Test";
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load;
            tlpMainContents.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            notesContainer.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxHamburger).EndInit();
            flpSidebarContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button subFlashcard;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Panel panel4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Panel panel5;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Panel panel6;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Panel panel10;
        private System.Windows.Forms.Timer tmrSidebar;
        private System.Windows.Forms.Timer tmrNotes;
        private TableLayoutPanel tlpMainContents;
        private Panel panel9;
        private Guna.UI2.WinForms.Guna2Button btnAnalytics;
        private Panel panel8;
        private Guna.UI2.WinForms.Guna2Button btnStudyLog;
        private Panel panel7;
        private Guna.UI2.WinForms.Guna2Button btnPlanner;
        private Panel notesContainer;
        private Guna.UI2.WinForms.Guna2Button subFlashcards;
        private Guna.UI2.WinForms.Guna2Button subNotebook;
        private Guna.UI2.WinForms.Guna2Button btnNotes;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Panel panel1;
        private Krypton.Toolkit.KryptonPictureBox pbxHamburger;
        private FlowLayoutPanel flpSidebarContainer;
        private Panel panelContents;
    }
}