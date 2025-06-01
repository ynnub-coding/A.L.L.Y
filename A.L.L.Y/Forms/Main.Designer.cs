namespace A.L.L.Y.Forms
{
    partial class Main
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tlpMainContents = new TableLayoutPanel();
            panel3 = new Panel();
            lblWelcome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panelMain = new Panel();
            tlpMainContents.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMainContents
            // 
            tlpMainContents.ColumnCount = 1;
            tlpMainContents.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMainContents.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tlpMainContents.Controls.Add(panel3, 0, 0);
            tlpMainContents.Controls.Add(panelMain, 0, 1);
            tlpMainContents.Dock = DockStyle.Fill;
            tlpMainContents.Location = new Point(0, 0);
            tlpMainContents.Margin = new Padding(3, 2, 3, 2);
            tlpMainContents.Name = "tlpMainContents";
            tlpMainContents.RowCount = 2;
            tlpMainContents.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMainContents.RowStyles.Add(new RowStyle(SizeType.Absolute, 424F));
            tlpMainContents.Size = new Size(998, 558);
            tlpMainContents.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblWelcome);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 2);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(992, 130);
            panel3.TabIndex = 10;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = false;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Dock = DockStyle.Fill;
            lblWelcome.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = SystemColors.ButtonHighlight;
            lblWelcome.Location = new Point(0, 0);
            lblWelcome.Margin = new Padding(3, 2, 3, 2);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(992, 130);
            lblWelcome.TabIndex = 5;
            lblWelcome.Text = "Welcome";
            lblWelcome.TextAlignment = ContentAlignment.MiddleCenter;
            lblWelcome.Click += lblWelcome_Click;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(3, 136);
            panelMain.Margin = new Padding(3, 2, 3, 2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(992, 420);
            panelMain.TabIndex = 11;
            panelMain.Paint += panelMain_Paint;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 25, 24);
            Controls.Add(tlpMainContents);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Main";
            Size = new Size(998, 558);
            Load += Main_Load;
            tlpMainContents.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2HtmlLabel lblWelcome;
        private TableLayoutPanel tlpMainContents;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Panel panel3;
        private Panel panel4;
        private Guna.UI2.WinForms.Guna2Button g;
        private Panel panelMain;
        #endregion
    }
}
