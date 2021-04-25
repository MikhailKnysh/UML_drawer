using System;
using System.Drawing;

namespace ArrowLine.Abstract
{
    public abstract class AbstractLine : AbstractFigure
    {

        public virtual Point[] CreateArrowLine()
        {
            int midlleX = (startPoint.X + endPoint.X) / 2;
            int midlleY = (startPoint.Y + endPoint.Y) / 2;
            Point[] linePoint = new Point[]
            {
                startPoint,
                 new Point(startPoint.X, midlleY),
                 new Point(endPoint.X, midlleY),
                endPoint
            };


            if (startPoint.X < endPoint.X && Math.Abs(startPoint.X - endPoint.X) > Math.Abs(startPoint.Y - endPoint.Y))
            {
                linePoint[1] = new Point(midlleX, startPoint.Y);
                linePoint[2] = new Point(midlleX, endPoint.Y);

            }
            else if (startPoint.Y < endPoint.Y && Math.Abs(startPoint.X - endPoint.X) < Math.Abs(startPoint.Y - endPoint.Y))
            {

                linePoint[1] = new Point(startPoint.X, midlleY);
                linePoint[2] = new Point(endPoint.X, midlleY);

            }

            if (startPoint.X > endPoint.X && Math.Abs(startPoint.X - endPoint.X) > Math.Abs(startPoint.Y - endPoint.Y))
            {
                linePoint[1] = new Point(midlleX, startPoint.Y);
                linePoint[2] = new Point(midlleX, endPoint.Y);
            }
            else if (startPoint.Y > endPoint.Y && Math.Abs(startPoint.X - endPoint.X) > Math.Abs(startPoint.Y - endPoint.Y))
            {
                linePoint[1] = new Point(midlleX, startPoint.Y);
                linePoint[2] = new Point(midlleX, endPoint.Y);
            }

            return linePoint;
        }

       
    }
}
