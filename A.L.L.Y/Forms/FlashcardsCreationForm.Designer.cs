namespace A.L.L.Y.Forms
{
    partial class FlashcardsCreationForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtQuestion = new Guna.UI2.WinForms.Guna2TextBox();
            txtAnswer = new Guna.UI2.WinForms.Guna2TextBox();
            lblDeckName = new Label();
            lsvCards = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            btnAddCard = new Guna.UI2.WinForms.Guna2Button();
            btnDeleteCard = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // txtQuestion
            // 
            txtQuestion.CustomizableEdges = customizableEdges1;
            txtQuestion.DefaultText = "";
            txtQuestion.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtQuestion.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtQuestion.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtQuestion.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtQuestion.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtQuestion.Font = new Font("Segoe UI", 9F);
            txtQuestion.ForeColor = Color.FromArgb(64, 64, 64);
            txtQuestion.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtQuestion.Location = new Point(48, 37);
            txtQuestion.Name = "txtQuestion";
            txtQuestion.PlaceholderText = "Question goes here";
            txtQuestion.SelectedText = "";
            txtQuestion.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtQuestion.Size = new Size(200, 36);
            txtQuestion.TabIndex = 0;
            // 
            // txtAnswer
            // 
            txtAnswer.CustomizableEdges = customizableEdges3;
            txtAnswer.DefaultText = "";
            txtAnswer.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtAnswer.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtAnswer.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtAnswer.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtAnswer.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtAnswer.Font = new Font("Segoe UI", 9F);
            txtAnswer.ForeColor = Color.FromArgb(64, 64, 64);
            txtAnswer.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtAnswer.Location = new Point(48, 91);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.PlaceholderText = "Answer Goes here";
            txtAnswer.SelectedText = "";
            txtAnswer.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtAnswer.Size = new Size(200, 36);
            txtAnswer.TabIndex = 1;
            // 
            // lblDeckName
            // 
            lblDeckName.AutoSize = true;
            lblDeckName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDeckName.ForeColor = Color.White;
            lblDeckName.Location = new Point(129, 7);
            lblDeckName.Name = "lblDeckName";
            lblDeckName.Size = new Size(64, 25);
            lblDeckName.TabIndex = 5;
            lblDeckName.Text = ".............";
            // 
            // lsvCards
            // 
            lsvCards.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lsvCards.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lsvCards.FullRowSelect = true;
            lsvCards.GridLines = true;
            lsvCards.Location = new Point(12, 133);
            lsvCards.Name = "lsvCards";
            lsvCards.Size = new Size(500, 300);
            lsvCards.TabIndex = 6;
            lsvCards.UseCompatibleStateImageBehavior = false;
            lsvCards.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Question";
            columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Answer";
            columnHeader2.Width = 200;
            // 
            // btnAddCard
            // 
            btnAddCard.BorderColor = Color.White;
            btnAddCard.BorderThickness = 1;
            btnAddCard.CustomizableEdges = customizableEdges5;
            btnAddCard.DisabledState.BorderColor = Color.DarkGray;
            btnAddCard.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddCard.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddCard.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddCard.FillColor = Color.FromArgb(24, 25, 24);
            btnAddCard.Font = new Font("Segoe UI", 9F);
            btnAddCard.ForeColor = Color.White;
            btnAddCard.Location = new Point(263, 107);
            btnAddCard.Name = "btnAddCard";
            btnAddCard.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnAddCard.Size = new Size(93, 20);
            btnAddCard.TabIndex = 7;
            btnAddCard.Text = "Add Card";
            btnAddCard.Click += btnAddCard_Click;
            // 
            // btnDeleteCard
            // 
            btnDeleteCard.BorderColor = Color.White;
            btnDeleteCard.BorderThickness = 1;
            btnDeleteCard.CustomizableEdges = customizableEdges7;
            btnDeleteCard.DisabledState.BorderColor = Color.DarkGray;
            btnDeleteCard.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDeleteCard.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDeleteCard.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDeleteCard.FillColor = Color.FromArgb(24, 25, 24);
            btnDeleteCard.Font = new Font("Segoe UI", 9F);
            btnDeleteCard.ForeColor = Color.White;
            btnDeleteCard.Location = new Point(378, 107);
            btnDeleteCard.Name = "btnDeleteCard";
            btnDeleteCard.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnDeleteCard.Size = new Size(93, 20);
            btnDeleteCard.TabIndex = 8;
            btnDeleteCard.Text = "Delete Card";
            btnDeleteCard.Click += btnDeleteCard_Click;
            // 
            // FlashcardsCreationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 25, 24);
            ClientSize = new Size(656, 482);
            Controls.Add(btnDeleteCard);
            Controls.Add(btnAddCard);
            Controls.Add(lsvCards);
            Controls.Add(lblDeckName);
            Controls.Add(txtAnswer);
            Controls.Add(txtQuestion);
            MinimumSize = new Size(672, 521);
            Name = "FlashcardsCreationForm";
            Text = "FlashcardsCreationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtQuestion;
        private Guna.UI2.WinForms.Guna2TextBox txtAnswer;
        private Label lblDeckName;
        private ListView lsvCards;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Guna.UI2.WinForms.Guna2Button btnAddCard;
        private Guna.UI2.WinForms.Guna2Button btnDeleteCard;
    }
}