namespace A.L.L.Y.Forms
{
    partial class Notes
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstNotes;
        private System.Windows.Forms.Button btnSave;
        /// <summary> 
        /// Required designer variable.
        /// </summary>
      

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
            components = new System.ComponentModel.Container();
            lstNotes = new ListBox();
            btnSave = new Button();
            tlpLayout = new TableLayoutPanel();
            panel1 = new Panel();
            txtTitle = new TextBox();
            lblAddNote = new Label();
            richtxtNotes = new RichTextBox();
            pbxLogo = new PictureBox();
            tmrSidebar = new System.Windows.Forms.Timer(components);
            contextMenuNotes = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            tmrNotes = new System.Windows.Forms.Timer(components);
            tlpLayout.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            contextMenuNotes.SuspendLayout();
            SuspendLayout();
            // 
            // lstNotes
            // 
            lstNotes.Dock = DockStyle.Fill;
            lstNotes.FormattingEnabled = true;
            lstNotes.Location = new Point(48, 103);
            lstNotes.Name = "lstNotes";
            lstNotes.Size = new Size(146, 576);
            lstNotes.TabIndex = 0;
            lstNotes.SelectedIndexChanged += lstNotes_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(652, 43);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 35);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // tlpLayout
            // 
            tlpLayout.ColumnCount = 3;
            tlpLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tlpLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 152F));
            tlpLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpLayout.Controls.Add(panel1, 2, 0);
            tlpLayout.Controls.Add(richtxtNotes, 2, 1);
            tlpLayout.Controls.Add(lstNotes, 1, 1);
            tlpLayout.Controls.Add(pbxLogo, 1, 0);
            tlpLayout.Dock = DockStyle.Fill;
            tlpLayout.Location = new Point(0, 0);
            tlpLayout.Name = "tlpLayout";
            tlpLayout.RowCount = 2;
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpLayout.Size = new Size(1223, 682);
            tlpLayout.TabIndex = 5;
            tlpLayout.Paint += tableLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTitle);
            panel1.Controls.Add(lblAddNote);
            panel1.Controls.Add(btnSave);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(200, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1020, 94);
            panel1.TabIndex = 6;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(319, 47);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Add new title...";
            txtTitle.Size = new Size(266, 27);
            txtTitle.TabIndex = 5;
            // 
            // lblAddNote
            // 
            lblAddNote.AutoSize = true;
            lblAddNote.Cursor = Cursors.Hand;
            lblAddNote.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAddNote.ForeColor = SystemColors.AppWorkspace;
            lblAddNote.Location = new Point(22, 30);
            lblAddNote.Name = "lblAddNote";
            lblAddNote.Size = new Size(274, 46);
            lblAddNote.TabIndex = 4;
            lblAddNote.Text = "Add new Notes...";
            lblAddNote.Click += lblAddNote_Click;
            // 
            // richtxtNotes
            // 
            richtxtNotes.Dock = DockStyle.Fill;
            richtxtNotes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richtxtNotes.Location = new Point(200, 103);
            richtxtNotes.Name = "richtxtNotes";
            richtxtNotes.Size = new Size(1020, 576);
            richtxtNotes.TabIndex = 2;
            richtxtNotes.Text = "";
            richtxtNotes.TextChanged += richtxtNotes_TextChanged;
            // 
            // pbxLogo
            // 
            pbxLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pbxLogo.Dock = DockStyle.Fill;
            pbxLogo.Location = new Point(48, 3);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(146, 94);
            pbxLogo.TabIndex = 7;
            pbxLogo.TabStop = false;
            pbxLogo.Click += pictureBox1_Click;
            // 
            // tmrSidebar
            // 
            tmrSidebar.Interval = 10;
            tmrSidebar.Tick += tmrSidebar_Tick;
            // 
            // contextMenuNotes
            // 
            contextMenuNotes.Font = new Font("Segoe UI", 9F);
            contextMenuNotes.ImageScalingSize = new Size(20, 20);
            contextMenuNotes.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            contextMenuNotes.Name = "contextMenuStrip1";
            contextMenuNotes.Size = new Size(123, 28);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(122, 24);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // tmrNotes
            // 
            tmrNotes.Interval = 10;
            tmrNotes.Tick += tmrNotes_Tick;
            // 
            // NoteTaking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 682);
            Controls.Add(tlpLayout);
            Name = "NoteTaking";
          
            Text = "NoteTaking";
         
            Load += NoteTaking_Load;
            tlpLayout.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            contextMenuNotes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpLayout;
        private Panel panel1;
        private Label lblAddNote;
        private PictureBox pbxLogo;
        private Guna.UI2.WinForms.Guna2Button subFlashcard;
        private Panel panel4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Panel panel5;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Panel panel6;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private System.Windows.Forms.Timer tmrSidebar;
        private RichTextBox richtxtNotes;
        private TextBox txtTitle;
        private ContextMenuStrip contextMenuNotes;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Timer tmrNotes;


    }
}
