using UMLDrawer.Abstract;
using System;
using System.Drawing;

namespace UMLDrawer.CapArrow
{
    public class OpenCapArrow : AbstractCapArrow
    {
        public OpenCapArrow(Point startPoint, Point endPoint)
        {
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
        }

        public override Point[] CreateArrowObject()
        {
            Point[] _CustomCapArrow = new Point[]
            {
                new Point(EndPoint.X, EndPoint.Y),
                EndPoint,
                new Point(EndPoint.X, EndPoint.Y)
            };

            if (StartPoint.X < EndPoint.X && Math.Abs(StartPoint.X - EndPoint.X) > Math.Abs(StartPoint.Y - EndPoint.Y))
            {
                _CustomCapArrow[0].Y -= _arrowSize;
                _CustomCapArrow[0].X -= _arrowSize;

                _CustomCapArrow[2].Y += _arrowSize;
                _CustomCapArrow[2].X -= _arrowSize;
            }
            else if (StartPoint.Y > EndPoint.Y && Math.Abs(StartPoint.X - EndPoint.X) < Math.Abs(StartPoint.Y - EndPoint.Y))
            {
                _CustomCapArrow[0].Y += _arrowSize;
                _CustomCapArrow[0].X -= _arrowSize;

                _CustomCapArrow[2].Y += _arrowSize;
                _CustomCapArrow[2].X += _arrowSize;
            }
            
            if (StartPoint.X > EndPoint.X && Math.Abs(StartPoint.X - EndPoint.X) > Math.Abs(StartPoint.Y - EndPoint.Y))
            {
                _CustomCapArrow[0].Y -= _arrowSize;
                _CustomCapArrow[0].X += _arrowSize;

                _CustomCapArrow[2].Y += _arrowSize;
                _CustomCapArrow[2].X += _arrowSize;
            }
            else if(StartPoint.Y < EndPoint.Y && Math.Abs(StartPoint.X - EndPoint.X) < Math.Abs(StartPoint.Y - EndPoint.Y))
            {
                _CustomCapArrow[0].Y -= _arrowSize;
                _CustomCapArrow[0].X += _arrowSize;

                _CustomCapArrow[2].Y -= _arrowSize;
                _CustomCapArrow[2].X -= _arrowSize;
            }

            return _CustomCapArrow;
        }

        public override void Draw()
        {
            GraphicsPictureBox.Graphics.DrawLines(pen, CreateArrowObject());
        }
    }
}
