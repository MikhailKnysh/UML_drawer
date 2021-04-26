using UMlDrawer.Abstract;
using System;
using System.Drawing;

namespace ArrowLine.Abstract
{
    public abstract class AbstractFigure 
    {
        private static float penWidth;
        private static Color color;
        protected Pen pen = new Pen(color, penWidth);

        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public FigureType Type { get; set; }
        public bool Selected { get; set; }
        public Color Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public float PenWidth
        {
            get
            {
                return penWidth;
            }
            set
            {
                penWidth = value;
            }
        }

        public abstract void Draw();

        public void SetDelta()
        {
            if (Math.Abs(StartPoint.X - EndPoint.X) < 20)
            {
                EndPoint = new Point(StartPoint.X, EndPoint.Y);
            }
            else if (Math.Abs(StartPoint.Y - EndPoint.Y) < 20)
            {
                EndPoint = new Point(EndPoint.X, StartPoint.Y);
            }
        }

        public void Move(int deltaX, int deltaY)
        {
            StartPoint = new Point(StartPoint.X + deltaX, StartPoint.Y + deltaY);
            EndPoint = new Point(EndPoint.X + deltaX, EndPoint.Y + deltaY);
        }
    }
}
