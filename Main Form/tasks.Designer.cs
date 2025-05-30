namespace Main_Form
{
    partial class tasks
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnBack = new Button();
            txtbTitle = new Guna.UI2.WinForms.Guna2TextBox();
            txtbBody = new Guna.UI2.WinForms.Guna2TextBox();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            dgvDataNotes = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDataNotes).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackgroundImageLayout = ImageLayout.Center;
            btnBack.Location = new Point(1048, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(20, 23);
            btnBack.TabIndex = 0;
            btnBack.Text = "<--";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtbTitle
            // 
            txtbTitle.Animated = true;
            txtbTitle.BorderColor = Color.Black;
            txtbTitle.BorderThickness = 2;
            txtbTitle.CustomizableEdges = customizableEdges1;
            txtbTitle.DefaultText = "Title";
            txtbTitle.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtbTitle.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtbTitle.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtbTitle.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtbTitle.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbTitle.Font = new Font("Segoe UI", 9F);
            txtbTitle.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbTitle.Location = new Point(21, 16);
            txtbTitle.Name = "txtbTitle";
            txtbTitle.PlaceholderText = "";
            txtbTitle.SelectedText = "";
            txtbTitle.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtbTitle.Size = new Size(351, 36);
            txtbTitle.TabIndex = 3;
            // 
            // txtbBody
            // 
            txtbBody.AcceptsReturn = true;
            txtbBody.AcceptsTab = true;
            txtbBody.BackgroundImageLayout = ImageLayout.None;
            txtbBody.BorderColor = Color.Black;
            txtbBody.BorderRadius = 1;
            txtbBody.BorderThickness = 2;
            txtbBody.CustomizableEdges = customizableEdges3;
            txtbBody.DefaultText = "Body";
            txtbBody.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtbBody.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtbBody.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtbBody.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtbBody.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbBody.Font = new Font("Segoe UI", 9F);
            txtbBody.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbBody.Location = new Point(21, 49);
            txtbBody.Name = "txtbBody";
            txtbBody.Padding = new Padding(20, 0, 0, 0);
            txtbBody.PlaceholderText = "";
            txtbBody.ScrollBars = ScrollBars.Vertical;
            txtbBody.SelectedText = "";
            txtbBody.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtbBody.Size = new Size(351, 390);
            txtbBody.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Animated = true;
            btnAdd.AutoRoundedCorners = true;
            btnAdd.BorderThickness = 2;
            btnAdd.CustomizableEdges = customizableEdges5;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor = Color.White;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(295, 455);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnAdd.Size = new Size(77, 25);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            // 
            // dgvDataNotes
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvDataNotes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDataNotes.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDataNotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDataNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDataNotes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDataNotes.GridColor = Color.FromArgb(231, 229, 255);
            dgvDataNotes.Location = new Point(409, 16);
            dgvDataNotes.Name = "dgvDataNotes";
            dgvDataNotes.RowHeadersVisible = false;
            dgvDataNotes.Size = new Size(298, 423);
            dgvDataNotes.TabIndex = 6;
            dgvDataNotes.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvDataNotes.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvDataNotes.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvDataNotes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvDataNotes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvDataNotes.ThemeStyle.BackColor = Color.White;
            dgvDataNotes.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvDataNotes.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvDataNotes.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDataNotes.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvDataNotes.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvDataNotes.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataNotes.ThemeStyle.HeaderStyle.Height = 4;
            dgvDataNotes.ThemeStyle.ReadOnly = false;
            dgvDataNotes.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvDataNotes.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDataNotes.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvDataNotes.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvDataNotes.ThemeStyle.RowsStyle.Height = 25;
            dgvDataNotes.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvDataNotes.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // tasks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1080, 512);
            Controls.Add(dgvDataNotes);
            Controls.Add(btnAdd);
            Controls.Add(txtbBody);
            Controls.Add(txtbTitle);
            Controls.Add(btnBack);
            Name = "tasks";
            Text = "tasks";
            ((System.ComponentModel.ISupportInitialize)dgvDataNotes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private Guna.UI2.WinForms.Guna2TextBox txtbTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtbBody;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDataNotes;
    }
}