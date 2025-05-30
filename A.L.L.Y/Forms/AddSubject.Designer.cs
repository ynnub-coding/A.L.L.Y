namespace A.L.L.Y.Forms
{
    partial class AddSubject
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
            guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            txtSubjectName = new Krypton.Toolkit.KryptonTextBox();
            pbxLogo = new PictureBox();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            btnSaveSubject = new Krypton.Toolkit.KryptonButton();
            btnChooseLogo = new Krypton.Toolkit.KryptonButton();
            txtSubjectDescription = new Krypton.Toolkit.KryptonTextBox();
            btnCancel = new Krypton.Toolkit.KryptonButton();
            guna2BorderlessForm2 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            lblSubjectName = new Label();
            lblSubjectDescription = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            SuspendLayout();
            // 
            // guna2HtmlToolTip1
            // 
            guna2HtmlToolTip1.AllowLinksHandling = true;
            guna2HtmlToolTip1.MaximumSize = new Size(0, 0);
            // 
            // txtSubjectName
            // 
            txtSubjectName.Location = new Point(34, 165);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(233, 27);
            txtSubjectName.TabIndex = 1;
            // 
            // pbxLogo
            // 
            pbxLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pbxLogo.Location = new Point(330, 21);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(168, 130);
            pbxLogo.TabIndex = 2;
            pbxLogo.TabStop = false;
            pbxLogo.Click += pbxLogo_Click;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnSaveSubject
            // 
            btnSaveSubject.Location = new Point(649, 405);
            btnSaveSubject.Name = "btnSaveSubject";
            btnSaveSubject.Size = new Size(127, 33);
            btnSaveSubject.TabIndex = 3;
            btnSaveSubject.Values.DropDownArrowColor = Color.Empty;
            btnSaveSubject.Values.Text = "Save";
            btnSaveSubject.Click += btnSaveSubject_Click;
            // 
            // btnChooseLogo
            // 
            btnChooseLogo.Location = new Point(522, 120);
            btnChooseLogo.Name = "btnChooseLogo";
            btnChooseLogo.Size = new Size(112, 31);
            btnChooseLogo.TabIndex = 4;
            btnChooseLogo.Values.DropDownArrowColor = Color.Empty;
            btnChooseLogo.Values.Text = "Choose Logo";
            btnChooseLogo.Click += btnChooseLogo_Click;
            // 
            // txtSubjectDescription
            // 
            txtSubjectDescription.Location = new Point(34, 238);
            txtSubjectDescription.Multiline = true;
            txtSubjectDescription.Name = "txtSubjectDescription";
            txtSubjectDescription.Size = new Size(742, 150);
            txtSubjectDescription.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(507, 405);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(127, 33);
            btnCancel.TabIndex = 6;
            btnCancel.Values.DropDownArrowColor = Color.Empty;
            btnCancel.Values.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // guna2BorderlessForm2
            // 
            guna2BorderlessForm2.ContainerControl = this;
            guna2BorderlessForm2.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm2.TransparentWhileDrag = true;
            // 
            // lblSubjectName
            // 
            lblSubjectName.AutoSize = true;
            lblSubjectName.Location = new Point(12, 131);
            lblSubjectName.Name = "lblSubjectName";
            lblSubjectName.Size = new Size(98, 20);
            lblSubjectName.TabIndex = 7;
            lblSubjectName.Text = "SubjectName";
            // 
            // lblSubjectDescription
            // 
            lblSubjectDescription.AutoSize = true;
            lblSubjectDescription.Location = new Point(12, 204);
            lblSubjectDescription.Name = "lblSubjectDescription";
            lblSubjectDescription.Size = new Size(85, 20);
            lblSubjectDescription.TabIndex = 8;
            lblSubjectDescription.Text = "Description";
            lblSubjectDescription.Click += lblSubjectDescription_Click;
            // 
            // AddSubject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSubjectDescription);
            Controls.Add(lblSubjectName);
            Controls.Add(btnCancel);
            Controls.Add(txtSubjectDescription);
            Controls.Add(btnChooseLogo);
            Controls.Add(btnSaveSubject);
            Controls.Add(pbxLogo);
            Controls.Add(txtSubjectName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddSubject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddSubject";
            Load += AddSubject_Load;
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private Krypton.Toolkit.KryptonTextBox txtSubjectName;
        private PictureBox pbxLogo;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Krypton.Toolkit.KryptonTextBox txtSubjectDescription;
        private Krypton.Toolkit.KryptonButton btnChooseLogo;
        private Krypton.Toolkit.KryptonButton btnSaveSubject;
        private Label lblSubjectDescription;
        private Label lblSubjectName;
        private Krypton.Toolkit.KryptonButton btnCancel;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm2;
    }
}