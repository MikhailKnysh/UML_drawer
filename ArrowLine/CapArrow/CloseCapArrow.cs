using ArrowLine.Abstract;
using System;
using System.Drawing;

namespace ArrowLine.CapArrow
{
    public class CloseCapArrow : AbstractArrowCap
    {
        public CloseCapArrow(Point startPoint, Point endPoint)
        {
            this.startPoint = startPoint;
            this.endPoint = endPoint;
        }

        public override Point[] CreateArrowObject()
        {
            Point[] _CustomCapArrow = new Point[]
            {
                endPoint,
                new Point(endPoint.X, endPoint.Y),
                new Point(endPoint.X, endPoint.Y),
                new Point(endPoint.X, endPoint.Y),
                endPoint,
            };

            if (startPoint.X < endPoint.X && Math.Abs(startPoint.X - endPoint.X) > Math.Abs(startPoint.Y - endPoint.Y))
            {
                _CustomCapArrow[1].Y -= _arrowSize;
                _CustomCapArrow[2].X += _arrowSize;
                _CustomCapArrow[3].Y += _arrowSize;
            }
            else if (startPoint.Y > endPoint.Y && Math.Abs(startPoint.X - endPoint.X) < Math.Abs(startPoint.Y - endPoint.Y))
            {
                _CustomCapArrow[1].X -= _arrowSize;
                _CustomCapArrow[2].Y -= _arrowSize;
                _CustomCapArrow[3].X += _arrowSize;
            }
            
            if (startPoint.X > endPoint.X && Math.Abs(startPoint.X - endPoint.X) > Math.Abs(startPoint.Y - endPoint.Y))
            {
                _CustomCapArrow[1].Y -= _arrowSize;
                _CustomCapArrow[2].X -= _arrowSize;
                _CustomCapArrow[3].Y += _arrowSize;
            }
            else if(startPoint.Y < endPoint.Y && Math.Abs(startPoint.X - endPoint.X) < Math.Abs(startPoint.Y - endPoint.Y))
            {
                
                _CustomCapArrow[1].X -= _arrowSize;
                _CustomCapArrow[2].Y += _arrowSize;
                _CustomCapArrow[3].X += _arrowSize;
            }

            return _CustomCapArrow;
        }

        public override void Draw()
        {

            GraficPictureBox.Graphics.DrawLines(pen, CreateArrowObject());
        }
    }
}
