namespace A.L.L.Y.Forms
{
    partial class FlashCards
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblEnterTitle = new Label();
            txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            btnAddDeck = new Button();
            lblExistingDecks = new Label();
            lstbDecks = new ListBox();
            btnDelete = new Button();
            pnlContent = new Panel();
            SuspendLayout();
            // 
            // lblEnterTitle
            // 
            lblEnterTitle.AutoSize = true;
            lblEnterTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEnterTitle.ForeColor = Color.White;
            lblEnterTitle.Location = new Point(6, 71);
            lblEnterTitle.Name = "lblEnterTitle";
            lblEnterTitle.Size = new Size(87, 21);
            lblEnterTitle.TabIndex = 0;
            lblEnterTitle.Text = "Enter title : ";
            // 
            // txtTitle
            // 
            txtTitle.CustomizableEdges = customizableEdges3;
            txtTitle.DefaultText = "";
            txtTitle.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTitle.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTitle.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTitle.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTitle.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTitle.Font = new Font("Segoe UI", 9F);
            txtTitle.ForeColor = Color.FromArgb(64, 64, 64);
            txtTitle.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTitle.Location = new Point(92, 71);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Title goes here";
            txtTitle.SelectedText = "";
            txtTitle.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtTitle.Size = new Size(200, 21);
            txtTitle.TabIndex = 1;
            // 
            // btnAddDeck
            // 
            btnAddDeck.BackgroundImageLayout = ImageLayout.None;
            btnAddDeck.FlatStyle = FlatStyle.Flat;
            btnAddDeck.ForeColor = Color.White;
            btnAddDeck.Location = new Point(213, 109);
            btnAddDeck.Name = "btnAddDeck";
            btnAddDeck.Size = new Size(79, 28);
            btnAddDeck.TabIndex = 2;
            btnAddDeck.Text = "ADD";
            btnAddDeck.UseVisualStyleBackColor = true;
            btnAddDeck.Click += btnAddDeck_Click;
            // 
            // lblExistingDecks
            // 
            lblExistingDecks.AutoSize = true;
            lblExistingDecks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExistingDecks.ForeColor = Color.White;
            lblExistingDecks.Location = new Point(6, 148);
            lblExistingDecks.Name = "lblExistingDecks";
            lblExistingDecks.Size = new Size(115, 21);
            lblExistingDecks.TabIndex = 3;
            lblExistingDecks.Text = "Existing Decks :";
            // 
            // lstbDecks
            // 
            lstbDecks.BackColor = Color.White;
            lstbDecks.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstbDecks.ForeColor = Color.Black;
            lstbDecks.FormattingEnabled = true;
            lstbDecks.ItemHeight = 15;
            lstbDecks.Location = new Point(12, 181);
            lstbDecks.Name = "lstbDecks";
            lstbDecks.Size = new Size(280, 214);
            lstbDecks.TabIndex = 4;
            lstbDecks.SelectedIndexChanged += lstbDecks_SelectedIndexChanged;
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImageLayout = ImageLayout.None;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(213, 412);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(79, 28);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // pnlContent
            // 
            pnlContent.Location = new Point(298, -1);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(672, 521);
            pnlContent.TabIndex = 6;
            // 
            // FlashCards
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 25, 24);
            ClientSize = new Size(982, 519);
            Controls.Add(pnlContent);
            Controls.Add(btnDelete);
            Controls.Add(lstbDecks);
            Controls.Add(lblExistingDecks);
            Controls.Add(btnAddDeck);
            Controls.Add(txtTitle);
            Controls.Add(lblEnterTitle);
            MinimumSize = new Size(998, 558);
            Name = "FlashCards";
            Text = "FlashCards";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEnterTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
        private Button btnAddDeck;
        private Label lblExistingDecks;
        private ListBox lstbDecks;
        private Button btnDelete;
        private Panel pnlContent;
    }
}