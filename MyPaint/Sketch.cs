using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public enum SketchTool
    {
        None,
        DrawRect,
        DrawCircle,
        DrawLine,
        Freedraw,
        Undo,
        Redo
    }
    // Painting : OnPaint
    public class Sketch: Control
    {
        public SketchTool SelectedTool { get; set; } = SketchTool.None;
        public Color ToolBorderColor { get; set; } = Color.Black;
        public Color ToolBackColor { get; set; } = Color.Transparent;
        public int ToolWidth { get; set; } = 2;

        private List<IDrawable> drawables;
        private Stack<IDrawable> history;

        public Sketch()
        {
            BackColor = Color.White;
            DoubleBuffered = true;
            drawables = new List<IDrawable>();
            history = new Stack<IDrawable>();
            previousPoint = new List<Point>();
        }

        public void SelectTool(SketchTool tool, Color border, Color background, int width)
        {
            SelectedTool = tool;
            ToolBorderColor = border;
            ToolBackColor = background;
            ToolWidth = width;
        }

        private Point currentPos;
        private Point downPos;
        private Point upPos;
        private bool isDown = false;
        private bool isMoving = false;
        protected override void OnMouseMove(MouseEventArgs e)
        {
            
            currentPos = e.Location;
            if (isDown)
            {
                isMoving = true;
                Console.WriteLine("Moving");
            }
            else
            {
                isMoving = false;
            }
            Invalidate();
            base.OnMouseMove(e);
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            Console.WriteLine("Down");
            downPos = e.Location;
            isDown = true;
            Invalidate();
            base.OnMouseDown(e);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            Console.WriteLine("Up");
            isDown = false;
            upPos = e.Location;
            Invalidate();
            base.OnMouseUp(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (IDrawable drawable in drawables)
            {
                drawable.Draw(e.Graphics);
            }
            switch (SelectedTool)
            {
                case SketchTool.None:
                    SelectNone();
                    break;
                case SketchTool.DrawRect:
                    DrawRect(e.Graphics);
                    break;
                case SketchTool.DrawCircle:
                    DrawCircle(e.Graphics);
                    break;
                case SketchTool.DrawLine:
                    DrawLine(e.Graphics);
                    break;
                case SketchTool.Freedraw:
                    Freedraw(e.Graphics);
                    break;
            }
           
        }
        private void SelectNone()
        {
            Cursor = Cursors.Default;
            downPos = new Point(0, 0);
            upPos = new Point(0, 0);
        }

        private void DrawRect(Graphics g)
        {
            Cursor = Cursors.Cross;
            if (isMoving)
            {

                g.DrawRectangle(new Pen(new SolidBrush(ToolBorderColor), ToolWidth), downPos.RectFromTwoPoint(currentPos));
            }
            if (!isDown && isMoving) // isMoving condition not set --> bị đè the next drawable's color
            {
                DrawableRectangle rectangle = new DrawableRectangle(new Pen(new SolidBrush(ToolBorderColor), ToolWidth), downPos.RectFromTwoPoint(upPos)) { BackColor = ToolBackColor };
                drawables.Add(rectangle);
            }
        }
        private void DrawCircle(Graphics g)
        {
            Cursor = Cursors.Cross;
            if (isMoving)
            {

                g.DrawEllipse(new Pen(new SolidBrush(ToolBorderColor), ToolWidth), downPos.RectFromTwoPoint(currentPos));
            }
            if (!isDown && isMoving)
            {
                DrawableCircle drawCircle = new DrawableCircle(new Pen(ToolBorderColor, ToolWidth), downPos.RectFromTwoPoint(upPos)) { BackColor = ToolBackColor };
                drawables.Add(drawCircle);
            }
        }
        private void DrawLine(Graphics g)
        {
            Cursor = Cursors.Cross;
            if (isMoving)
            {
                g.DrawLine(new Pen(new SolidBrush(ToolBorderColor), ToolWidth),downPos,currentPos);
            }
            if (!isDown && isMoving)
            {
               
                DrawableLine drawableLine = new DrawableLine(new Pen(ToolBorderColor,ToolWidth), downPos,upPos);
           
                drawables.Add(drawableLine);
            }
        }
        private List<Point> previousPoint;
        private void Freedraw(Graphics g)
        {
            Cursor = Cursors.Cross;
          
            if (isMoving)
            {
                previousPoint.Add(currentPos);
                if (previousPoint.Count > 1)
                {
                    g.DrawLines(new Pen(ToolBorderColor,ToolWidth), previousPoint.ToArray());
                }
            }
            if (!isDown && isMoving)
            {
                List<Point> points = new List<Point>(previousPoint);
                DrawableFreeline drawableFreeline = new DrawableFreeline(new Pen(ToolBorderColor,ToolWidth),points);
                drawables.Add(drawableFreeline);
                previousPoint.Clear();
            }
        }

        public bool Undo()
        {
            if (drawables.Count > 0)
            {
                history.Push(drawables[drawables.Count - 1]); // get the lastest drawable
                drawables.RemoveAt(drawables.Count - 1);
            }
            Invalidate();
            return history.Count > 0;
        }
        public bool Redo()
        {
            if (history.Count > 0)
            {
                drawables.Add(history.Pop()); // get drawable from history stack -> add to drawables List
            }
            Invalidate();
            return history.Count > 0;
        }
        public void Clear()
        {
            drawables.Clear();
            history.Clear();
            SelectedTool = SketchTool.None;
            Invalidate();
        }
        public void Save(string fileName)
        {
            Image image = new Bitmap(Width, Height);
            Graphics paper = Graphics.FromImage(image);
            foreach(IDrawable drawable in drawables)
            {
                drawable.Draw(paper);
            }
            paper.Save();
            image.Save(fileName);
        }
    }
}
