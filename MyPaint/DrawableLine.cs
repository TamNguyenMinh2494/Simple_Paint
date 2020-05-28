using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    class DrawableLine : Shape, IDrawable
    {
        public DrawableLine(Pen p, Point p1, Point p2) : base(p, p1.X, p1.Y, p2.X, p2.Y) { }
        public DrawableLine(Pen p, int x1, int y1, int x2, int y2) : base(p, x1, y1, x2, y2)
        {

        }
        public void Draw(Graphics g)
        {
            g.DrawLine(Pen, X, Y, Width, Height);
        }
    }
}
