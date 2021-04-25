using ArrowLine.Abstract;
using System;
using System.Drawing;

namespace ArrowLine.CapArrow
{
    public class OpenCapArrow : AbstractArrowCap
    {
        public OpenCapArrow(Point startPoint, Point endPoint)
        {
            this.startPoint = startPoint;
            this.endPoint = endPoint;
        }

        public override Point[] CreateArrowObject()
        {
            Point[] _CustomCapArrow = new Point[]
              {
                new Point(endPoint.X, endPoint.Y),
                endPoint,
                new Point(endPoint.X, endPoint.Y)
              };

            if (startPoint.X < endPoint.X && Math.Abs(startPoint.X - endPoint.X) > Math.Abs(startPoint.Y - endPoint.Y))
            {
                _CustomCapArrow[0].Y -= _arrowSize;
                _CustomCapArrow[0].X -= _arrowSize;

                _CustomCapArrow[2].Y += _arrowSize;
                _CustomCapArrow[2].X -= _arrowSize;
            }
            else if (startPoint.Y > endPoint.Y && Math.Abs(startPoint.X - endPoint.X) < Math.Abs(startPoint.Y - endPoint.Y))
            {
                _CustomCapArrow[0].Y += _arrowSize;
                _CustomCapArrow[0].X -= _arrowSize;

                _CustomCapArrow[2].Y += _arrowSize;
                _CustomCapArrow[2].X += _arrowSize;
            }
            
            if (startPoint.X > endPoint.X && Math.Abs(startPoint.X - endPoint.X) > Math.Abs(startPoint.Y - endPoint.Y))
            {
                _CustomCapArrow[0].Y -= _arrowSize;
                _CustomCapArrow[0].X += _arrowSize;

                _CustomCapArrow[2].Y += _arrowSize;
                _CustomCapArrow[2].X += _arrowSize;
            }
            else if(startPoint.Y < endPoint.Y && Math.Abs(startPoint.X - endPoint.X) < Math.Abs(startPoint.Y - endPoint.Y))
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
            GraficPictureBox.Graphics.DrawLines(pen, CreateArrowObject());
        }
    }
}
