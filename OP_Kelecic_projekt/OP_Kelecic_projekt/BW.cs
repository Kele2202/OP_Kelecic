using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OP_Kelecic_projekt
{
    class BW : RemoveColor
    {
        public BW(int width, int height) : base(width, height)
        {

        }

        public override Bitmap DoEdit(Bitmap image)
        {
            int rgb;
            Color c;
            for (int y = 0; y < image.Height; y++)
                for (int x = 0; x < image.Width; x++)
                {
                    c = image.GetPixel(x, y);
                    rgb = (int)((c.R + c.G + c.B) / 3);
                    image.SetPixel(x, y, Color.FromArgb(rgb, rgb, rgb));
                }
            return image;
        }
    }
}
