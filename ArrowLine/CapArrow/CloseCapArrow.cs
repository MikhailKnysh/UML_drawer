using System.Drawing;

namespace ArrowLine.CapArrow
{
    public class CloseCapArrow : AbstractArrow, IArrowCap
    {
        public CloseCapArrow(Point startPoint, Point endPoint)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
        }

        public Point[] CreateArrowObject()
        {
            Point[] _CustomCapArrow = new Point[]
            {
                _endPoint,
                new Point(_endPoint.X, _endPoint.Y),
                new Point(_endPoint.X, _endPoint.Y),
                new Point(_endPoint.X, _endPoint.Y),
                _endPoint,
            };

            if (_startPoint.X < _endPoint.X)
            {
                _CustomCapArrow[1].Y -= _arrowSize;
                _CustomCapArrow[2].X += _arrowSize;
                _CustomCapArrow[3].Y += _arrowSize;
            }
            else if (_startPoint.Y > _endPoint.Y && _startPoint.X == _endPoint.X)
            {
                _CustomCapArrow[1].X -= _arrowSize;
                _CustomCapArrow[2].Y -= _arrowSize;
                _CustomCapArrow[3].X += _arrowSize;
            }
            else if (_startPoint.X > _endPoint.X)
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

        public override void Draw(Pen pen, Graphics graphics)
        {

            graphics.DrawLines(pen, CreateArrowObject());
        }
    }
}
