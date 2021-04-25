using System;
using System.Drawing;

namespace ArrowLine.Abstract
{

    public enum FigureType
    {
        Arrow,
        Table
    }

    public abstract class AbstractFigure 
    {
        public Point startPoint { get; set; }
        public Point endPoint { get; set; }
        public static float penWidth;
        public static Color color;
      
        protected Pen pen = new Pen(color, penWidth);
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
        public void Delta()
        {
            
            if (Math.Abs(startPoint.X - endPoint.X) < 20)
            {
                endPoint = new Point(startPoint.X, endPoint.Y);
            }
            else if (Math.Abs(startPoint.Y - endPoint.Y) < 20)
            {
                endPoint = new Point(endPoint.X, startPoint.Y);
            }
        }

        public void Move(int deltaX, int deltaY)
        {
            startPoint = new Point(startPoint.X + deltaX, startPoint.Y + deltaY);
            endPoint = new Point(endPoint.X + deltaX, endPoint.Y + deltaY);
        }
    }
}
