using System;
using System.Drawing;

namespace UMLDrawer.Abstract
{
    public abstract class AbstractLine : AbstractFigure
    {
        public virtual Point[] CreateArrowLine()
        {
            int midlleX = (StartPoint.X + EndPoint.X) / 2;
            int midlleY = (StartPoint.Y + EndPoint.Y) / 2;

            Point[] linePoint = new Point[]
            {
                StartPoint,
                 new Point(StartPoint.X, midlleY),
                 new Point(EndPoint.X, midlleY),
                EndPoint
            };

            if (StartPoint.X < EndPoint.X && Math.Abs(StartPoint.X - EndPoint.X) > Math.Abs(StartPoint.Y - EndPoint.Y))
            {
                linePoint[1] = new Point(midlleX, StartPoint.Y);
                linePoint[2] = new Point(midlleX, EndPoint.Y);

            }
            else if (StartPoint.Y < EndPoint.Y && Math.Abs(StartPoint.X - EndPoint.X) < Math.Abs(StartPoint.Y - EndPoint.Y))
            {

                linePoint[1] = new Point(StartPoint.X, midlleY);
                linePoint[2] = new Point(EndPoint.X, midlleY);

            }

            if (StartPoint.X > EndPoint.X && Math.Abs(StartPoint.X - EndPoint.X) > Math.Abs(StartPoint.Y - EndPoint.Y))
            {
                linePoint[1] = new Point(midlleX, StartPoint.Y);
                linePoint[2] = new Point(midlleX, EndPoint.Y);
            }
            else if (StartPoint.Y > EndPoint.Y && Math.Abs(StartPoint.X - EndPoint.X) > Math.Abs(StartPoint.Y - EndPoint.Y))
            {
                linePoint[1] = new Point(midlleX, StartPoint.Y);
                linePoint[2] = new Point(midlleX, EndPoint.Y);
            }

            return linePoint;
        }
    }
}
