using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_Kelecic_projekt
{
    class RemoveColor : IDisposable
    {
        int mHeight, mWidth;

        public RemoveColor(int width, int height)
        {
            mHeight = height;
            mWidth = width;
        }

        public virtual Bitmap DoEdit (Bitmap image)
        {
            image = new Bitmap(image, mWidth, mHeight);
            return image;
        }

        void IDisposable.Dispose() { }
    }
}