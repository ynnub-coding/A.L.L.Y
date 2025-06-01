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
            tlpMainContents.Location = new Point(48, 0);
            tlpMainContents.Margin = new Padding(3, 2, 3, 2);
            tlpMainContents.Name = "tlpMainContents";
            tlpMainContents.RowCount = 1;
            tlpMainContents.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMainContents.Size = new Size(1004, 562);
            tlpMainContents.TabIndex = 11;
            tlpMainContents.Paint += tableLayoutPanel1_Paint;
            // 
            // panelContents
            // 
            panelContents.Dock = DockStyle.Fill;
            panelContents.Location = new Point(3, 2);
            panelContents.Margin = new Padding(3, 2, 3, 2);
            panelContents.Name = "panelContents";
            panelContents.Size = new Size(998, 558);
            panelContents.TabIndex = 0;
            panelContents.Paint += panelContents_Paint;
            // 
            // panel9
            // 
            panel9.Controls.Add(btnAnalytics);
            panel9.Cursor = Cursors.Hand;
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(3, 263);
            panel9.Margin = new Padding(3, 2, 3, 2);
            panel9.MaximumSize = new Size(239, 43);
            panel9.MinimumSize = new Size(239, 43);
            panel9.Name = "panel9";
            panel9.Size = new Size(239, 43);
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
            btnAnalytics.Dock = DockStyle.Top;
            btnAnalytics.FillColor = Color.FromArgb(33, 32, 33);
            btnAnalytics.FocusedColor = Color.FromArgb(33, 32, 33);
            btnAnalytics.Font = new Font("Segoe UI", 12.75F);
            btnAnalytics.ForeColor = Color.FromArgb(195, 195, 195);
            btnAnalytics.Image = Properties.Resources.hollow_chart;
            btnAnalytics.ImageOffset = new Point(-100, 0);
            btnAnalytics.ImageSize = new Size(45, 45);
            btnAnalytics.IndicateFocus = true;
            btnAnalytics.Location = new Point(0, 0);
            btnAnalytics.Margin = new Padding(3, 2, 3, 2);
            btnAnalytics.MaximumSize = new Size(239, 28);
            btnAnalytics.MinimumSize = new Size(239, 28);
            btnAnalytics.Name = "btnAnalytics";
            btnAnalytics.Padding = new Padding(10, 0, 0, 0);
            btnAnalytics.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAnalytics.Size = new Size(239, 28);
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
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(3, 216);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.MaximumSize = new Size(239, 43);
            panel8.MinimumSize = new Size(239, 43);
            panel8.Name = "panel8";
            panel8.Size = new Size(239, 43);
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
            btnStudyLog.Dock = DockStyle.Top;
            btnStudyLog.FillColor = Color.FromArgb(33, 32, 33);
            btnStudyLog.FocusedColor = Color.FromArgb(33, 32, 33);
            btnStudyLog.Font = new Font("Segoe UI", 12.75F);
            btnStudyLog.ForeColor = Color.FromArgb(195, 195, 195);
            btnStudyLog.Image = Properties.Resources.hollow_white_folder;
            btnStudyLog.ImageOffset = new Point(-100, 0);
            btnStudyLog.ImageSize = new Size(45, 45);
            btnStudyLog.IndicateFocus = true;
            btnStudyLog.Location = new Point(0, 0);
            btnStudyLog.Margin = new Padding(3, 2, 3, 2);
            btnStudyLog.MaximumSize = new Size(239, 28);
            btnStudyLog.MinimumSize = new Size(239, 28);
            btnStudyLog.Name = "btnStudyLog";
            btnStudyLog.Padding = new Padding(10, 0, 0, 0);
            btnStudyLog.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnStudyLog.Size = new Size(239, 28);
            btnStudyLog.TabIndex = 9;
            btnStudyLog.Text = "        Study Log";
            btnStudyLog.TextAlign = HorizontalAlignment.Left;
            btnStudyLog.Click += btnStudyLog_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnPlanner);
            panel7.Cursor = Cursors.Hand;
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(3, 169);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.MaximumSize = new Size(239, 43);
            panel7.MinimumSize = new Size(239, 43);
            panel7.Name = "panel7";
            panel7.Size = new Size(239, 43);
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
            btnPlanner.Dock = DockStyle.Top;
            btnPlanner.FillColor = Color.FromArgb(33, 32, 33);
            btnPlanner.FocusedColor = Color.FromArgb(33, 32, 33);
            btnPlanner.Font = new Font("Segoe UI", 12.75F);
            btnPlanner.ForeColor = Color.FromArgb(195, 195, 195);
            btnPlanner.Image = Properties.Resources.hollow_calendar;
            btnPlanner.ImageOffset = new Point(-100, 0);
            btnPlanner.ImageSize = new Size(35, 35);
            btnPlanner.IndicateFocus = true;
            btnPlanner.Location = new Point(0, 0);
            btnPlanner.Margin = new Padding(3, 2, 3, 2);
            btnPlanner.MaximumSize = new Size(239, 28);
            btnPlanner.MinimumSize = new Size(239, 28);
            btnPlanner.Name = "btnPlanner";
            btnPlanner.Padding = new Padding(10, 0, 0, 0);
            btnPlanner.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnPlanner.Size = new Size(239, 28);
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
            notesContainer.Dock = DockStyle.Top;
            notesContainer.Location = new Point(3, 122);
            notesContainer.Margin = new Padding(3, 2, 3, 2);
            notesContainer.MaximumSize = new Size(239, 99);
            notesContainer.MinimumSize = new Size(239, 43);
            notesContainer.Name = "notesContainer";
            notesContainer.Size = new Size(239, 43);
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
            subFlashcards.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subFlashcards.ForeColor = Color.FromArgb(195, 195, 195);
            subFlashcards.Image = Properties.Resources.hollow_dot;
            subFlashcards.ImageOffset = new Point(-80, 0);
            subFlashcards.ImageSize = new Size(25, 25);
            subFlashcards.Location = new Point(-3, 64);
            subFlashcards.Margin = new Padding(3, 2, 3, 2);
            subFlashcards.Name = "subFlashcards";
            subFlashcards.ShadowDecoration.CustomizableEdges = customizableEdges8;
            subFlashcards.Size = new Size(239, 28);
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
            subNotebook.Font = new Font("Segoe UI", 9F);
            subNotebook.ForeColor = Color.FromArgb(195, 195, 195);
            subNotebook.Image = Properties.Resources.hollow_dot;
            subNotebook.ImageOffset = new Point(-80, 0);
            subNotebook.ImageSize = new Size(25, 25);
            subNotebook.Location = new Point(-3, 42);
            subNotebook.Margin = new Padding(3, 2, 3, 2);
            subNotebook.Name = "subNotebook";
            subNotebook.ShadowDecoration.CustomizableEdges = customizableEdges10;
            subNotebook.Size = new Size(239, 28);
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
            btnNotes.Dock = DockStyle.Top;
            btnNotes.FillColor = Color.FromArgb(33, 32, 33);
            btnNotes.FocusedColor = Color.FromArgb(33, 32, 33);
            btnNotes.Font = new Font("Segoe UI", 12.75F);
            btnNotes.ForeColor = Color.FromArgb(195, 195, 195);
            btnNotes.Image = Properties.Resources.hollow_closed_notebook;
            btnNotes.ImageOffset = new Point(-100, 0);
            btnNotes.ImageSize = new Size(35, 35);
            btnNotes.IndicateFocus = true;
            btnNotes.Location = new Point(0, 0);
            btnNotes.Margin = new Padding(3, 2, 3, 2);
            btnNotes.MaximumSize = new Size(239, 28);
            btnNotes.MinimumSize = new Size(239, 28);
            btnNotes.Name = "btnNotes";
            btnNotes.Padding = new Padding(10, 0, 0, 0);
            btnNotes.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnNotes.Size = new Size(239, 28);
            btnNotes.TabIndex = 9;
            btnNotes.Text = "        Notes";
            btnNotes.TextAlign = HorizontalAlignment.Left;
            btnNotes.Click += btnNotes_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnHome);
            panel2.Cursor = Cursors.Hand;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 75);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.MaximumSize = new Size(239, 43);
            panel2.MinimumSize = new Size(239, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(239, 43);
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
            btnHome.Dock = DockStyle.Top;
            btnHome.FillColor = Color.FromArgb(33, 32, 33);
            btnHome.FocusedColor = Color.FromArgb(33, 32, 33);
            btnHome.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.FromArgb(195, 195, 195);
            btnHome.Image = Properties.Resources.Filled_home;
            btnHome.ImageOffset = new Point(-100, 0);
            btnHome.ImageSize = new Size(35, 35);
            btnHome.IndicateFocus = true;
            btnHome.Location = new Point(0, 0);
            btnHome.Margin = new Padding(3, 2, 3, 2);
            btnHome.MaximumSize = new Size(239, 28);
            btnHome.MinimumSize = new Size(239, 28);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(10, 0, 0, 0);
            btnHome.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnHome.Size = new Size(239, 28);
            btnHome.TabIndex = 9;
            btnHome.Text = "        Home";
            btnHome.TextAlign = HorizontalAlignment.Left;
            btnHome.Click += btnHome_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pbxHamburger);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.MaximumSize = new Size(239, 69);
            panel1.MinimumSize = new Size(239, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 69);
            panel1.TabIndex = 0;
            // 
            // pbxHamburger
            // 
            pbxHamburger.Cursor = Cursors.Hand;
            pbxHamburger.Image = Properties.Resources.hamburger;
            pbxHamburger.Location = new Point(8, 7);
            pbxHamburger.Margin = new Padding(3, 2, 3, 2);
            pbxHamburger.MaximumSize = new Size(31, 26);
            pbxHamburger.MinimumSize = new Size(31, 26);
            pbxHamburger.Name = "pbxHamburger";
            pbxHamburger.Size = new Size(31, 26);
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
            flpSidebarContainer.Margin = new Padding(3, 2, 3, 2);
            flpSidebarContainer.MaximumSize = new Size(242, 7499);
            flpSidebarContainer.MinimumSize = new Size(48, 7499);
            flpSidebarContainer.Name = "flpSidebarContainer";
            flpSidebarContainer.Size = new Size(48, 7499);
            flpSidebarContainer.TabIndex = 10;
            flpSidebarContainer.Paint += flpSidebarContainer_Paint;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 562);
            Controls.Add(tlpMainContents);
            Controls.Add(flpSidebarContainer);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1068, 601);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Test";
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