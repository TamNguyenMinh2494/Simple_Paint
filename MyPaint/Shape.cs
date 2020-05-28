using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    public class Shape
    {
        public Pen Pen { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Color BackColor { get; set; } = Color.Transparent;

        public Shape() { }
        public Shape(Pen p, int x, int y, int width, int height)
        {
            Pen = p;
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }
    }
}
