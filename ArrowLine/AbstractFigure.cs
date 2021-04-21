using System;
using System.Drawing;

namespace ArrowLine
{
    //make as interface

    public abstract class AbstractFigure : IMoveable1
    {
        public DataPictureBox singltone = DataPictureBox.GetInstance();
        public Point startPoint;
        public Point endPoint;
        protected Region objectRegion;
        public bool Selected { get; set; }




        public abstract void Draw();
        public void Delta()
        {
            if (Math.Abs(startPoint.X - endPoint.X) < 20)
            {

                endPoint.X = startPoint.X;
            }
            else if (Math.Abs(startPoint.Y - endPoint.Y) < 20)
            {
                endPoint.Y = startPoint.Y;
            }
        }

        public virtual void AddField()
        { }

        public virtual void AddProperty()
        { }

        public virtual void AddMethod()
        { }

        public void Move(int deltaX, int deltaY)
        {
            startPoint = new Point(startPoint.X + deltaX, startPoint.Y + deltaY);
            endPoint = new Point(endPoint.X + deltaX, endPoint.Y + deltaY);
        }
    }
}
