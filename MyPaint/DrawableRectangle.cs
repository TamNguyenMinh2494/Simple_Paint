using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    public class DrawableRectangle : Shape, IDrawable
    {

        public DrawableRectangle(Pen pen, Rectangle rect) : base(pen, rect.X, rect.Y, rect.Width, rect.Height) { }

        public DrawableRectangle(Pen pen, int x, int y, int width, int height) : base(pen, x, y, width, height)
        {

        }

        public void Draw(Graphics g)
        {
            if(BackColor != Color.Transparent)
            {
                g.FillRectangle(new SolidBrush(BackColor), X, Y, Width, Height);
            }
            g.DrawRectangle(Pen, X, Y, Width, Height);
        }
    }
}
