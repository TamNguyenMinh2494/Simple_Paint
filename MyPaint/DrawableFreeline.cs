using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    class DrawableFreeline: IDrawable
    {
        private List<Point> points;
        private Pen pen;
        public DrawableFreeline(Pen p, List<Point> pointList)
        {
            pen = p;
            points = pointList;
        }
        public void Draw(Graphics g)
        {
            if (points.Count > 1)
            {
                g.DrawLines(pen, points.ToArray());
            }

        }
    }
}
