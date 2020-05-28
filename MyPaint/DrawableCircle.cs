using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    public class DrawableCircle : Shape, IDrawable
    {
        public DrawableCircle(Pen p, Rectangle rect) : base(p, rect.X, rect.Y, rect.Width, rect.Height) { }
        public DrawableCircle(Pen p, int x, int y, int width, int height) : base(p, x, y, width, height)
        {
        }

        public void Draw(Graphics g)
        {
            if (BackColor != Color.Transparent)
            {
                g.FillEllipse(new SolidBrush(BackColor), X, Y, Width, Height);
            }
            g.DrawEllipse(Pen, X, Y, Width, Height);
        }
    }
}
