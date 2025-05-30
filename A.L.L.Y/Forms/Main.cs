using A.L.L.Y.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using A.L.L.Y.Database;
using A.L.L.Y.Models;
using System;
using System.Data.SQLite;

namespace A.L.L.Y.Forms
{
    public partial class Main : UserControl
    {
        private string _userName;
        private int _userId;
        public Main(string userName)
        {
            InitializeComponent();

            _userName = userName;
            Resizer.ResizeFont(lblWelcome, this, 0.04f);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            int hour = DateTime.Now.Hour;
            if (hour < 12)
            {
                lblWelcome.Text = $"Good Morning, {_userName}...";
            }
            else if (hour < 18)
            {
                lblWelcome.Text = $"Good Afternoon, {_userName}...";
            }
            else
            {
                lblWelcome.Text = $"Good Evening, {_userName}...";
            }
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

      
    }
}
