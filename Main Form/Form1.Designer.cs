namespace Main_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlMain = new Panel();
            btnSetting = new Button();
            pnlOrganize = new Panel();
            btnCalendar = new Button();
            btnTasks = new Button();
            btnOrganize = new Button();
            pnlFocus = new Panel();
            btnFlashcard = new Button();
            btnTimer = new Button();
            btnFocus = new Button();
            btnProfile = new Button();
            pnlLogo = new Panel();
            pnlMain.SuspendLayout();
            pnlOrganize.SuspendLayout();
            pnlFocus.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.BorderStyle = BorderStyle.FixedSingle;
            pnlMain.Controls.Add(btnSetting);
            pnlMain.Controls.Add(pnlOrganize);
            pnlMain.Controls.Add(btnOrganize);
            pnlMain.Controls.Add(pnlFocus);
            pnlMain.Controls.Add(btnFocus);
            pnlMain.Controls.Add(btnProfile);
            pnlMain.Controls.Add(pnlLogo);
            pnlMain.Dock = DockStyle.Left;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(169, 600);
            pnlMain.TabIndex = 0;
            // 
            // btnSetting
            // 
            btnSetting.Dock = DockStyle.Top;
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSetting.Image = (Image)resources.GetObject("btnSetting.Image");
            btnSetting.ImageAlign = ContentAlignment.MiddleLeft;
            btnSetting.Location = new Point(0, 392);
            btnSetting.Name = "btnSetting";
            btnSetting.Padding = new Padding(20, 0, 0, 0);
            btnSetting.Size = new Size(167, 33);
            btnSetting.TabIndex = 0;
            btnSetting.Text = "Settings";
            btnSetting.UseVisualStyleBackColor = true;
            btnSetting.Click += btnSetting_Click;
            // 
            // pnlOrganize
            // 
            pnlOrganize.BackColor = Color.LightGray;
            pnlOrganize.Controls.Add(btnCalendar);
            pnlOrganize.Controls.Add(btnTasks);
            pnlOrganize.Dock = DockStyle.Top;
            pnlOrganize.Location = new Point(0, 325);
            pnlOrganize.Name = "pnlOrganize";
            pnlOrganize.Size = new Size(167, 67);
            pnlOrganize.TabIndex = 3;
            // 
            // btnCalendar
            // 
            btnCalendar.Dock = DockStyle.Top;
            btnCalendar.FlatAppearance.BorderSize = 0;
            btnCalendar.FlatStyle = FlatStyle.Flat;
            btnCalendar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCalendar.Image = Properties.Resources.calendar;
            btnCalendar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCalendar.Location = new Point(0, 33);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Padding = new Padding(30, 0, 0, 0);
            btnCalendar.Size = new Size(167, 33);
            btnCalendar.TabIndex = 0;
            btnCalendar.Text = "Calendar";
            btnCalendar.UseVisualStyleBackColor = true;
            btnCalendar.Click += btnCalendar_Click;
            // 
            // btnTasks
            // 
            btnTasks.Dock = DockStyle.Top;
            btnTasks.FlatAppearance.BorderColor = Color.Gray;
            btnTasks.FlatAppearance.BorderSize = 0;
            btnTasks.FlatStyle = FlatStyle.Flat;
            btnTasks.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnTasks.Image = (Image)resources.GetObject("btnTasks.Image");
            btnTasks.ImageAlign = ContentAlignment.MiddleLeft;
            btnTasks.Location = new Point(0, 0);
            btnTasks.Name = "btnTasks";
            btnTasks.Padding = new Padding(30, 0, 0, 0);
            btnTasks.RightToLeft = RightToLeft.No;
            btnTasks.Size = new Size(167, 33);
            btnTasks.TabIndex = 2;
            btnTasks.Text = "Tasks";
            btnTasks.UseVisualStyleBackColor = true;
            btnTasks.Click += btnTasks_Click;
            // 
            // btnOrganize
            // 
            btnOrganize.Dock = DockStyle.Top;
            btnOrganize.FlatAppearance.BorderColor = Color.Gray;
            btnOrganize.FlatAppearance.BorderSize = 0;
            btnOrganize.FlatStyle = FlatStyle.Flat;
            btnOrganize.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnOrganize.Image = (Image)resources.GetObject("btnOrganize.Image");
            btnOrganize.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrganize.Location = new Point(0, 292);
            btnOrganize.Name = "btnOrganize";
            btnOrganize.Padding = new Padding(20, 0, 0, 0);
            btnOrganize.Size = new Size(167, 33);
            btnOrganize.TabIndex = 1;
            btnOrganize.Text = "Organize";
            btnOrganize.UseVisualStyleBackColor = true;
            btnOrganize.Click += btnOrganize_Click;
            // 
            // pnlFocus
            // 
            pnlFocus.BackColor = Color.FromArgb(224, 224, 224);
            pnlFocus.Controls.Add(btnFlashcard);
            pnlFocus.Controls.Add(btnTimer);
            pnlFocus.Dock = DockStyle.Top;
            pnlFocus.Location = new Point(0, 223);
            pnlFocus.Name = "pnlFocus";
            pnlFocus.Size = new Size(167, 69);
            pnlFocus.TabIndex = 1;
            // 
            // btnFlashcard
            // 
            btnFlashcard.Dock = DockStyle.Top;
            btnFlashcard.FlatAppearance.BorderColor = Color.Gray;
            btnFlashcard.FlatAppearance.BorderSize = 0;
            btnFlashcard.FlatStyle = FlatStyle.Flat;
            btnFlashcard.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnFlashcard.Image = (Image)resources.GetObject("btnFlashcard.Image");
            btnFlashcard.ImageAlign = ContentAlignment.MiddleLeft;
            btnFlashcard.Location = new Point(0, 33);
            btnFlashcard.Name = "btnFlashcard";
            btnFlashcard.Padding = new Padding(30, 0, 0, 0);
            btnFlashcard.Size = new Size(167, 33);
            btnFlashcard.TabIndex = 0;
            btnFlashcard.Text = "Flashcards";
            btnFlashcard.UseVisualStyleBackColor = true;
            btnFlashcard.Click += btnFlashcard_Click;
            // 
            // btnTimer
            // 
            btnTimer.Dock = DockStyle.Top;
            btnTimer.FlatAppearance.BorderColor = Color.Gray;
            btnTimer.FlatAppearance.BorderSize = 0;
            btnTimer.FlatStyle = FlatStyle.Flat;
            btnTimer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnTimer.Image = (Image)resources.GetObject("btnTimer.Image");
            btnTimer.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimer.Location = new Point(0, 0);
            btnTimer.Name = "btnTimer";
            btnTimer.Padding = new Padding(30, 0, 0, 0);
            btnTimer.Size = new Size(167, 33);
            btnTimer.TabIndex = 0;
            btnTimer.Text = "Timer";
            btnTimer.UseVisualStyleBackColor = true;
            btnTimer.Click += btnTimer_Click;
            // 
            // btnFocus
            // 
            btnFocus.Dock = DockStyle.Top;
            btnFocus.FlatAppearance.BorderColor = Color.Gray;
            btnFocus.FlatAppearance.BorderSize = 0;
            btnFocus.FlatStyle = FlatStyle.Flat;
            btnFocus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnFocus.Image = Properties.Resources.eye_arrow_progress;
            btnFocus.ImageAlign = ContentAlignment.MiddleLeft;
            btnFocus.Location = new Point(0, 190);
            btnFocus.Name = "btnFocus";
            btnFocus.Padding = new Padding(20, 0, 0, 0);
            btnFocus.Size = new Size(167, 33);
            btnFocus.TabIndex = 0;
            btnFocus.Text = "Focus";
            btnFocus.UseVisualStyleBackColor = true;
            btnFocus.Click += btnFocus_Click;
            // 
            // btnProfile
            // 
            btnProfile.Dock = DockStyle.Top;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfile.Image = Properties.Resources.user1;
            btnProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfile.Location = new Point(0, 157);
            btnProfile.Name = "btnProfile";
            btnProfile.Padding = new Padding(20, 0, 0, 0);
            btnProfile.RightToLeft = RightToLeft.No;
            btnProfile.Size = new Size(167, 33);
            btnProfile.TabIndex = 0;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(167, 157);
            pnlLogo.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(950, 600);
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            pnlMain.ResumeLayout(false);
            pnlOrganize.ResumeLayout(false);
            pnlFocus.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Button btnProfile;
        private Button btnCalendar;
        private Button btnFocus;
        private Button btnSetting;
        private Panel pnlFocus;
        private Button btnFlashcard;
        private Button btnTimer;
        private Panel pnlLogo;
        private Panel pnlOrganize;
        private Button btnTasks;
        private Button btnOrganize;
    }
}
