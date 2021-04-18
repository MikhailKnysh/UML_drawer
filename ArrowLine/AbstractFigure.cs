using System;
using System.Drawing;

namespace ArrowLine
{
    //make as interface

    public abstract class AbstractFigure
    {
        public DataPictureBox singltone = DataPictureBox.GetInstance();
        public Point startPoint;
        public Point endPoint;
        protected Region objectRegion;
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
    }
}
