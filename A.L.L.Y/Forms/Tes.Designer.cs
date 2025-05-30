namespace A.L.L.Y.Forms
{
    partial class Tes
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
            TemplatePanel = new Panel();
            lblTemplatePanel = new Label();
            pbxTemplatePanel = new PictureBox();
            panel4 = new Panel();
            panel5 = new Panel();
            label4 = new Label();
            testPanel = new Panel();
            subjectPanel = new Panel();
            lblSubject = new Label();
            subjectLogo = new PictureBox();
            TemplatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxTemplatePanel).BeginInit();
            panel4.SuspendLayout();
            subjectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)subjectLogo).BeginInit();
            SuspendLayout();
            // 
            // TemplatePanel
            // 
            TemplatePanel.BackColor = Color.Transparent;
            TemplatePanel.BackgroundImage = Properties.Resources.NotesOpen_removebg_preview;
            TemplatePanel.BackgroundImageLayout = ImageLayout.Stretch;
            TemplatePanel.Controls.Add(lblTemplatePanel);
            TemplatePanel.Controls.Add(pbxTemplatePanel);
            TemplatePanel.ForeColor = Color.Black;
            TemplatePanel.Location = new Point(47, 53);
            TemplatePanel.Name = "TemplatePanel";
            TemplatePanel.Size = new Size(507, 380);
            TemplatePanel.TabIndex = 2;
            TemplatePanel.Paint += TemplatePanel_Paint;
            // 
            // lblTemplatePanel
            // 
            lblTemplatePanel.BackColor = Color.Transparent;
            lblTemplatePanel.Location = new Point(283, 117);
            lblTemplatePanel.Name = "lblTemplatePanel";
            lblTemplatePanel.Size = new Size(171, 173);
            lblTemplatePanel.TabIndex = 1;
            lblTemplatePanel.Text = "ssbsbsbsb hrh rhzhrzhzrh r hzrh rh h h hhhhrh h h h h hhrhrhrzhzft rhezdfzbdthztyWGgvrf";
            // 
            // pbxTemplatePanel
            // 
            pbxTemplatePanel.BackgroundImage = Properties.Resources.Screenshot__3_;
            pbxTemplatePanel.BackgroundImageLayout = ImageLayout.Stretch;
            pbxTemplatePanel.Location = new Point(88, 106);
            pbxTemplatePanel.Name = "pbxTemplatePanel";
            pbxTemplatePanel.Size = new Size(119, 164);
            pbxTemplatePanel.TabIndex = 0;
            pbxTemplatePanel.TabStop = false;
            pbxTemplatePanel.Click += pictureBox2_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = Properties.Resources.NotbookClosed_Default_removebg_preview;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label4);
            panel4.ForeColor = Color.Black;
            panel4.Location = new Point(332, 439);
            panel4.Name = "panel4";
            panel4.Size = new Size(278, 415);
            panel4.TabIndex = 3;
            panel4.Paint += panel4_Paint;
            panel4.MouseEnter += panel4_MouseEnter;
            panel4.MouseLeave += panel4_MouseLeave;
            panel4.MouseHover += panel4_MouseHover;
            // 
            // panel5
            // 
            panel5.BackgroundImage = Properties.Resources.Screenshot__3_;
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Location = new Point(88, 107);
            panel5.Name = "panel5";
            panel5.Size = new Size(119, 164);
            panel5.TabIndex = 4;
            panel5.Visible = false;
            panel5.Paint += panel5_Paint;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(283, 117);
            label4.Name = "label4";
            label4.Size = new Size(171, 173);
            label4.TabIndex = 2;
            label4.Text = "ssbsbsbsb hrh rhzhrzhzrh r hzrh rh h h hhhhrh h h h h hhrhrhrzhzft rhezdfzbdthztyWGgvrf";
            label4.Click += label4_Click;
            // 
            // testPanel
            // 
            testPanel.Location = new Point(596, 53);
            testPanel.Name = "testPanel";
            testPanel.Size = new Size(827, 393);
            testPanel.TabIndex = 4;
            testPanel.Paint += testPanel_Paint;
            // 
            // subjectPanel
            // 
            subjectPanel.BackColor = Color.Transparent;
            subjectPanel.BackgroundImage = Properties.Resources.NotbookClosed_Default_removebg_preview;
            subjectPanel.BackgroundImageLayout = ImageLayout.Stretch;
            subjectPanel.Controls.Add(subjectLogo);
            subjectPanel.Controls.Add(lblSubject);
            subjectPanel.ForeColor = Color.Black;
            subjectPanel.Location = new Point(745, 452);
            subjectPanel.Name = "subjectPanel";
            subjectPanel.Size = new Size(278, 415);
            subjectPanel.TabIndex = 5;
            subjectPanel.Paint += subjectPanel_Paint;
            // 
            // lblSubject
            // 
            lblSubject.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            lblSubject.Location = new Point(72, 104);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(133, 51);
            lblSubject.TabIndex = 0;
            lblSubject.Text = "Subject";
            lblSubject.TextAlign = ContentAlignment.MiddleCenter;
            lblSubject.Click += label1_Click_1;
            // 
            // subjectLogo
            // 
            subjectLogo.Location = new Point(72, 188);
            subjectLogo.Name = "subjectLogo";
            subjectLogo.Size = new Size(133, 122);
            subjectLogo.TabIndex = 1;
            subjectLogo.TabStop = false;
            // 
            // Tes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1530, 875);
            Controls.Add(subjectPanel);
            Controls.Add(testPanel);
            Controls.Add(panel4);
            Controls.Add(TemplatePanel);
            Name = "Tes";
            TemplatePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxTemplatePanel).EndInit();
            panel4.ResumeLayout(false);
            subjectPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)subjectLogo).EndInit();
            ResumeLayout(false);
        }

        private Panel notesContainer;
        private Guna.UI2.WinForms.Guna2Button subNotebook;
        private Guna.UI2.WinForms.Guna2Button subFlashcard;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Panel panel5;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Panel panel10;

#endregion
        private Panel TemplatePanel;
        private Label lblTemplatePanel;
        private PictureBox pbxTemplatePanel;
        private Panel panel4;
        private Label label4;
        private Panel testPanel;
        private Panel subjectPanel;
        private Label lblSubject;
        private PictureBox subjectLogo;
    }
}


       
