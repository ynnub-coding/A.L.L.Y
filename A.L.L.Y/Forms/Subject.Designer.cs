namespace A.L.L.Y.Forms
{
    partial class Subject
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
            components = new System.ComponentModel.Container();
            guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            cmSubjects = new ContextMenuStrip(components);
            deleteSubjectMenuItem = new ToolStripMenuItem();
            panelAddContainer = new Panel();
            lblAdd = new Label();
            tbpSubjectFormLayout = new TableLayoutPanel();
            flowSubjects = new Panel();
            guna2ContextMenuStrip1.SuspendLayout();
            cmSubjects.SuspendLayout();
            panelAddContainer.SuspendLayout();
            tbpSubjectFormLayout.SuspendLayout();
            SuspendLayout();
            // 
            // guna2ContextMenuStrip1
            // 
            guna2ContextMenuStrip1.ImageScalingSize = new Size(20, 20);
            guna2ContextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            guna2ContextMenuStrip1.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            guna2ContextMenuStrip1.RenderStyle.BorderColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SeparatorColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            guna2ContextMenuStrip1.Size = new Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // cmSubjects
            // 
            cmSubjects.BackgroundImage = Properties.Resources.NotbookClosed_Default_removebg_preview;
            cmSubjects.ImageScalingSize = new Size(20, 20);
            cmSubjects.Items.AddRange(new ToolStripItem[] { deleteSubjectMenuItem });
            cmSubjects.Name = "cmSubjects";
            cmSubjects.Size = new Size(108, 26);
            // 
            // deleteSubjectMenuItem
            // 
            deleteSubjectMenuItem.Name = "deleteSubjectMenuItem";
            deleteSubjectMenuItem.Size = new Size(107, 22);
            deleteSubjectMenuItem.Text = "Delete";
            deleteSubjectMenuItem.Click += deleteSubjectMenuItem_Click;
            // 
            // panelAddContainer
            // 
            panelAddContainer.Controls.Add(lblAdd);
            panelAddContainer.Dock = DockStyle.Fill;
            panelAddContainer.Location = new Point(63, 2);
            panelAddContainer.Margin = new Padding(3, 2, 3, 2);
            panelAddContainer.Name = "panelAddContainer";
            panelAddContainer.Size = new Size(932, 94);
            panelAddContainer.TabIndex = 10;
            panelAddContainer.Paint += panel1_Paint_1;
            // 
            // lblAdd
            // 
            lblAdd.AutoSize = true;
            lblAdd.Cursor = Cursors.Hand;
            lblAdd.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAdd.ForeColor = SystemColors.AppWorkspace;
            lblAdd.Location = new Point(10, 20);
            lblAdd.Name = "lblAdd";
            lblAdd.Size = new Size(327, 37);
            lblAdd.TabIndex = 2;
            lblAdd.Text = "Click me to add subjects...";
            lblAdd.TextAlign = ContentAlignment.MiddleCenter;
            lblAdd.Click += lblAdd_Click;
            // 
            // tbpSubjectFormLayout
            // 
            tbpSubjectFormLayout.ColumnCount = 2;
            tbpSubjectFormLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tbpSubjectFormLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tbpSubjectFormLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tbpSubjectFormLayout.Controls.Add(panelAddContainer, 1, 0);
            tbpSubjectFormLayout.Controls.Add(flowSubjects, 1, 1);
            tbpSubjectFormLayout.Dock = DockStyle.Fill;
            tbpSubjectFormLayout.Location = new Point(0, 0);
            tbpSubjectFormLayout.Margin = new Padding(3, 2, 3, 2);
            tbpSubjectFormLayout.Name = "tbpSubjectFormLayout";
            tbpSubjectFormLayout.RowCount = 2;
            tbpSubjectFormLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 98F));
            tbpSubjectFormLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tbpSubjectFormLayout.Size = new Size(998, 558);
            tbpSubjectFormLayout.TabIndex = 7;
            tbpSubjectFormLayout.Paint += tbpSubjectFormLayout_Paint;
            // 
            // flowSubjects
            // 
            flowSubjects.AutoScroll = true;
            flowSubjects.Dock = DockStyle.Fill;
            flowSubjects.Location = new Point(63, 100);
            flowSubjects.Margin = new Padding(3, 2, 3, 2);
            flowSubjects.Name = "flowSubjects";
            flowSubjects.Size = new Size(932, 456);
            flowSubjects.TabIndex = 11;
            flowSubjects.Paint += flowSubjects_Paint_4;
            // 
            // Subject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbpSubjectFormLayout);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(998, 558);
            Name = "Subject";
            Size = new Size(998, 558);
            guna2ContextMenuStrip1.ResumeLayout(false);
            cmSubjects.ResumeLayout(false);
            panelAddContainer.ResumeLayout(false);
            panelAddContainer.PerformLayout();
            tbpSubjectFormLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private ContextMenuStrip cmSubjects;
        private ToolStripMenuItem deleteSubjectMenuItem;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2Button subFlashcard;
        private Panel panel4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Panel panel5;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Panel panel6;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Panel panelAddContainer;
        private Label lblAdd;
        private TableLayoutPanel tbpSubjectFormLayout;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Panel flowSubjects;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}
