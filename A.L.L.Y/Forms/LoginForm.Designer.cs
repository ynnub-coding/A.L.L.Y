namespace A.L.L.Y.Forms
{
    partial class LoginForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            linkRegister = new LinkLabel();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            lblMessage = new Label();
            panel1 = new Panel();
            btnClose = new Button();
            ptbBackground = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbBackground).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(40, 41, 40);
            txtUsername.BorderColor = Color.Gray;
            txtUsername.BorderThickness = 2;
            txtUsername.CustomizableEdges = customizableEdges1;
            txtUsername.DefaultText = "";
            txtUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.FillColor = Color.FromArgb(24, 25, 24);
            txtUsername.FocusedState.BorderColor = Color.FromArgb(31, 81, 131);
            txtUsername.Font = new Font("Segoe UI", 9F);
            txtUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.IconLeft = (Image)resources.GetObject("txtUsername.IconLeft");
            txtUsername.Location = new Point(323, 104);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtUsername.Size = new Size(340, 28);
            txtUsername.TabIndex = 2;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Checked = true;
            btnLogin.CustomizableEdges = customizableEdges3;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.FillColor = Color.FromArgb(35, 131, 226);
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(252, 253, 252);
            btnLogin.Location = new Point(345, 205);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnLogin.Size = new Size(290, 26);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOGIN";
            btnLogin.Click += btnLogin_Click;
            // 
            // linkRegister
            // 
            linkRegister.AutoSize = true;
            linkRegister.BackColor = Color.Transparent;
            linkRegister.Location = new Point(534, 247);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(61, 15);
            linkRegister.TabIndex = 5;
            linkRegister.TabStop = true;
            linkRegister.Text = "Click Here";
            linkRegister.LinkClicked += linkRegister_LinkClicked;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(40, 41, 40);
            txtPassword.BorderColor = Color.Gray;
            txtPassword.BorderThickness = 2;
            txtPassword.CustomizableEdges = customizableEdges5;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FillColor = Color.FromArgb(24, 25, 24);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(31, 81, 131);
            txtPassword.Font = new Font("Segoe UI", 9F);
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.IconLeft = (Image)resources.GetObject("txtPassword.IconLeft");
            txtPassword.Location = new Point(323, 156);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtPassword.Size = new Size(340, 28);
            txtPassword.TabIndex = 9;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.BackColor = Color.Transparent;
            lblMessage.FlatStyle = FlatStyle.Flat;
            lblMessage.ForeColor = SystemColors.ButtonHighlight;
            lblMessage.Location = new Point(377, 247);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(147, 15);
            lblMessage.TabIndex = 10;
            lblMessage.Text = "Dont have an account yet?";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 30);
            panel1.TabIndex = 11;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(64, 64, 64);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.Transparent;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(660, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 30);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // ptbBackground
            // 
            ptbBackground.BackColor = Color.Transparent;
            ptbBackground.Dock = DockStyle.Fill;
            ptbBackground.Image = (Image)resources.GetObject("ptbBackground.Image");
            ptbBackground.Location = new Point(0, 0);
            ptbBackground.Name = "ptbBackground";
            ptbBackground.Size = new Size(700, 400);
            ptbBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbBackground.TabIndex = 12;
            ptbBackground.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 25, 24);
            ClientSize = new Size(700, 400);
            Controls.Add(panel1);
            Controls.Add(lblMessage);
            Controls.Add(txtPassword);
            Controls.Add(linkRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtUsername);
            Controls.Add(ptbBackground);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "A";
            Load += LoginForm_Load_1;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbBackground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private LinkLabel linkRegister;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Label lblMessage;
        private Panel panel1;
        private Button btnClose;
        private PictureBox ptbBackground;
    }
}