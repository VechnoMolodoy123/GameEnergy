using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameEnergy.Classes.Customization
{
    internal class RoundingHelper
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse);

        public static void SetRoundedRegion(Panel panel, int widthEllipse, int heightEllipse)
        {
            IntPtr region = CreateRoundRectRgn(0, 0, panel.Width, panel.Height, widthEllipse, heightEllipse);
            if (region != IntPtr.Zero)
            {
                panel.Region = System.Drawing.Region.FromHrgn(region);
            }
        }

        public static void SetRoundedRegion(PictureBox image, int widthEllipse, int heightEllipse)
        {
            IntPtr region = CreateRoundRectRgn(0, 0, image.Width, image.Height, widthEllipse, heightEllipse);
            if (region != IntPtr.Zero)
            {
                image.Region = System.Drawing.Region.FromHrgn(region);
            }
        }
    }
}
