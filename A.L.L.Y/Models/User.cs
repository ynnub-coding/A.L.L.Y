using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.L.L.Y.Models
{
    internal class User
    {
        public int UserID { get; set; }      // Primary Key
        public string Name { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Preferences { get; set; } // (Optional, e.g., dark mode, etc.)

    }
}
