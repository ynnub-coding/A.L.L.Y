using System.Drawing;

namespace A.L.L.Y.Database.Models
{
    public class Subject
    {
        public int Id { get; set; }          // Unique ID (primary key)
        public string Name { get; set; }     // Subject name (required)
        public string Description { get; set; } // Optional description
        public byte[] LogoData { get; set; } // Image data stored as byte array (for DB)

        public int UserId { get; set; }      // Owner user ID

        // Helper property to get/set the logo as Image (not stored directly in DB)
        public Image Logo
        {
            get
            {
                if (LogoData == null) return null;
                using (var ms = new System.IO.MemoryStream(LogoData))
                {
                    return Image.FromStream(ms);
                }
            }
            set
            {
                if (value == null)
                {
                    LogoData = null;
                }
                else
                {
                    using (var ms = new System.IO.MemoryStream())
                    {
                        value.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        LogoData = ms.ToArray();
                    }
                }
            }
        }
    }
}
