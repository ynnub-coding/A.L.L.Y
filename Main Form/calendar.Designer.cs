namespace Main_Form
{
    partial class calendar
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
            monthCalendar1 = new MonthCalendar();
            btnBack = new Button();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.CalendarDimensions = new Size(2, 2);
            monthCalendar1.Location = new Point(133, 95);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(13, 11);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 33);
            btnBack.TabIndex = 1;
            btnBack.Text = "<-";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // calendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 512);
            Controls.Add(btnBack);
            Controls.Add(monthCalendar1);
            Name = "calendar";
            Text = "calendar";
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Button btnBack;
    }
}