using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A.L.L.Y.Utils
{
    public static class Resizer
    {
        /// <summary>
        /// Resizes and optionally repositions a control based on percentage of its parent.
        /// </summary>
        /// <param name="control">The control to resize (e.g., Button).</param>
        /// <param name="parent">The parent container (e.g., Form or Panel).</param>
        /// <param name="widthPercent">Width as a decimal (e.g., 0.2 = 20%).</param>
        /// <param name="heightPercent">Height as a decimal (e.g., 0.1 = 10%).</param>
        /// <param name="center">Whether to center the control in its parent.</param>
        public static void ResizeControl(Control control, Control parent, float widthPercent, float heightPercent, float leftPercent = 0, float topPercent = 0, bool center = false)
        {
            int newWidth = (int)(parent.ClientSize.Width * widthPercent);
            int newHeight = (int)(parent.ClientSize.Height * heightPercent);

            control.Width = newWidth;
            control.Height = newHeight;

            if (center)
            {
                control.Left = (parent.ClientSize.Width - newWidth) / 2;
                control.Top = (parent.ClientSize.Height - newHeight) / 2;
            }
            else
            {
                control.Left = (int)(parent.ClientSize.Width * leftPercent);
                control.Top = (int)(parent.ClientSize.Height * topPercent);
            }
        }

        public static void ResizeFont(Control control, Control parent, float heightPercent)
        {
            float fontSize = parent.ClientSize.Height * heightPercent;
            control.Font = new Font(control.Font.FontFamily, fontSize, control.Font.Style);
        }

    }
}
