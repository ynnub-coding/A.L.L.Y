namespace A.L.L.Y.Forms
{
    partial class RegisterForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnRegister = new Guna.UI2.WinForms.Guna2Button();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            txtName = new Guna.UI2.WinForms.Guna2TextBox();
            pnlTopLevel = new Panel();
            btnClose = new Button();
            ptbBackGround = new PictureBox();
            lblWelcome = new Label();
            lblDescription = new Label();
            pnlTopLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbBackGround).BeginInit();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Transparent;
            btnRegister.BorderColor = Color.White;
            btnRegister.BorderThickness = 1;
            btnRegister.CustomBorderColor = Color.White;
            btnRegister.CustomizableEdges = customizableEdges1;
            btnRegister.DisabledState.BorderColor = Color.DarkGray;
            btnRegister.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRegister.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRegister.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRegister.FillColor = Color.Black;
            btnRegister.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(158, 268);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnRegister.Size = new Size(98, 20);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "REGISTER";
            btnRegister.Click += btnRegister_Click;
            // 
            // txtPassword
            // 
            txtPassword.BorderColor = Color.Silver;
            txtPassword.CustomizableEdges = customizableEdges3;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FillColor = SystemColors.Control;
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Segoe UI", 9F);
            txtPassword.ForeColor = Color.Black;
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.IconLeft = (Image)resources.GetObject("txtPassword.IconLeft");
            txtPassword.Location = new Point(42, 228);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderForeColor = Color.FromArgb(64, 64, 64);
            txtPassword.PlaceholderText = "Password";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtPassword.Size = new Size(214, 25);
            txtPassword.TabIndex = 9;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.BorderColor = Color.Silver;
            txtUsername.CustomizableEdges = customizableEdges5;
            txtUsername.DefaultText = "";
            txtUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.FillColor = SystemColors.Control;
            txtUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Font = new Font("Segoe UI", 9F);
            txtUsername.ForeColor = Color.Black;
            txtUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.IconLeft = (Image)resources.GetObject("txtUsername.IconLeft");
            txtUsername.Location = new Point(42, 197);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderForeColor = Color.FromArgb(64, 64, 64);
            txtUsername.PlaceholderText = "Username";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtUsername.Size = new Size(214, 25);
            txtUsername.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.BackColor = Color.Transparent;
            txtName.BackgroundImageLayout = ImageLayout.Center;
            txtName.BorderColor = Color.Black;
            txtName.CustomizableEdges = customizableEdges7;
            txtName.DefaultText = "";
            txtName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtName.FillColor = SystemColors.Control;
            txtName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Font = new Font("Segoe UI", 9F);
            txtName.ForeColor = Color.Black;
            txtName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Location = new Point(42, 166);
            txtName.Name = "txtName";
            txtName.PlaceholderForeColor = Color.FromArgb(64, 64, 64);
            txtName.PlaceholderText = "How should we call you?";
            txtName.SelectedText = "";
            txtName.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtName.Size = new Size(214, 25);
            txtName.TabIndex = 13;
            txtName.TextChanged += guna2TextBox1_TextChanged;
            // 
            // pnlTopLevel
            // 
            pnlTopLevel.BackColor = Color.FromArgb(64, 64, 64);
            pnlTopLevel.Controls.Add(btnClose);
            pnlTopLevel.Dock = DockStyle.Top;
            pnlTopLevel.ForeColor = SystemColors.ButtonHighlight;
            pnlTopLevel.Location = new Point(0, 0);
            pnlTopLevel.Name = "pnlTopLevel";
            pnlTopLevel.Size = new Size(700, 29);
            pnlTopLevel.TabIndex = 14;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(64, 64, 64);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.Transparent;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(664, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(36, 29);
            btnClose.TabIndex = 15;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // ptbBackGround
            // 
            ptbBackGround.BackColor = Color.Transparent;
            ptbBackGround.Dock = DockStyle.Fill;
            ptbBackGround.Image = (Image)resources.GetObject("ptbBackGround.Image");
            ptbBackGround.Location = new Point(0, 0);
            ptbBackGround.Name = "ptbBackGround";
            ptbBackGround.Size = new Size(700, 400);
            ptbBackGround.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbBackGround.TabIndex = 15;
            ptbBackGround.TabStop = false;
            ptbBackGround.Click += ptbBackGround_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.Black;
            lblWelcome.Location = new Point(488, 100);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(146, 32);
            lblWelcome.TabIndex = 16;
            lblWelcome.Text = "WELCOME !";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.Black;
            lblDescription.Location = new Point(389, 141);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(289, 204);
            lblDescription.TabIndex = 17;
            lblDescription.Text = resources.GetString("lblDescription.Text");
            lblDescription.TextAlign = ContentAlignment.MiddleRight;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 400);
            Controls.Add(lblDescription);
            Controls.Add(lblWelcome);
            Controls.Add(pnlTopLevel);
            Controls.Add(txtName);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(ptbBackGround);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(700, 400);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            pnlTopLevel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbBackGround).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnRegister;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Panel pnlTopLevel;
        private Button btnClose;
        private PictureBox ptbBackGround;
        private Label lblWelcome;
        private Label lblDescription;
    }
}