using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    public static class Extensions
    {
        public static Rectangle RectFromTwoPoint(this Point p1, Point p2)
        {
            int deltaX = p2.X - p1.X;
            int deltaY = p2.Y - p1.Y;
            if (deltaX > 0 && deltaY > 0) // left to bottom right
            {
                return new Rectangle(p1.X, p1.Y, deltaX, deltaY);
            }
            if(deltaX < 0 && deltaY < 0) // right to top left
            {
                return new Rectangle(p2.X, p2.Y, -deltaX, -deltaY);
            }
            if(deltaX>0 && deltaY < 0) // right to bottom left
            {
                return new Rectangle(p1.X, p2.Y, deltaX, -deltaY);
            }

            // deltaX<0 && deltaY > 0 // left to top right
                return new Rectangle(p2.X, p1.Y, -deltaX, deltaY);
            

        }
    }
}
