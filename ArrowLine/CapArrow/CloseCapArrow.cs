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

            if (startPoint.X < endPoint.X)
            {
                _CustomCapArrow[1].Y -= _arrowSize;
                _CustomCapArrow[2].X += _arrowSize;
                _CustomCapArrow[3].Y += _arrowSize;
            }
            else if (startPoint.Y > endPoint.Y && startPoint.X == endPoint.X)
            {
                _CustomCapArrow[1].X -= _arrowSize;
                _CustomCapArrow[2].Y -= _arrowSize;
                _CustomCapArrow[3].X += _arrowSize;
            }
            else if (startPoint.X > endPoint.X)
            {
                _CustomCapArrow[1].Y -= _arrowSize;
                _CustomCapArrow[2].X -= _arrowSize;
                _CustomCapArrow[3].Y += _arrowSize;
            }
            else
            {
                _CustomCapArrow[1].X -= _arrowSize;
                _CustomCapArrow[2].Y += _arrowSize;
                _CustomCapArrow[3].X += _arrowSize;
            }

            return _CustomCapArrow;
        }

        public override void Draw()
        {

            singltone.Graphics.DrawLines(singltone.pen, CreateArrowObject());
        }
    }
}
