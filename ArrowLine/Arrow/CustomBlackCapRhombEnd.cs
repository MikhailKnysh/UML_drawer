using System.Drawing;

namespace ArrowLine.Arrow
{
    public class CustomBlackCapRhombEnd : AbstractArrow, IArrowCap
    {
        public CustomBlackCapRhombEnd(Point startPoint, Point endPoint)
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
                _CustomCapArrow[1].X -= _arrowSize;
                _CustomCapArrow[1].Y -= _arrowSize;

                _CustomCapArrow[2].X -= 2 * _arrowSize;

                _CustomCapArrow[3].X -= _arrowSize;
                _CustomCapArrow[3].Y += _arrowSize;
            }
            else if (_startPoint.Y > _endPoint.Y && _startPoint.X == _endPoint.X)
            {
                _CustomCapArrow[1].X += _arrowSize;
                _CustomCapArrow[1].Y += _arrowSize;

                _CustomCapArrow[2].Y += 2 * _arrowSize;

                _CustomCapArrow[3].X -= _arrowSize;
                _CustomCapArrow[3].Y += _arrowSize;
            }
            else if (_startPoint.X > _endPoint.X)
            {
                _CustomCapArrow[1].X += _arrowSize;
                _CustomCapArrow[1].Y -= _arrowSize;

                _CustomCapArrow[2].X += 2 * _arrowSize;

                _CustomCapArrow[3].X += _arrowSize;
                _CustomCapArrow[3].Y += _arrowSize;
            }
            else
            {
                _CustomCapArrow[1].X -= _arrowSize;
                _CustomCapArrow[1].Y -= _arrowSize;

                _CustomCapArrow[2].Y -= 2 * _arrowSize;

                _CustomCapArrow[3].X += _arrowSize;
                _CustomCapArrow[3].Y -= _arrowSize;
            }

            return _CustomCapArrow;
        }

        public override void Draw(Pen pen,Graphics graphics)
        {
            SolidBrush shadowBrush = new SolidBrush(pen.Color);

            graphics.DrawPolygon(pen, CreateArrowObject());
            graphics.FillPolygon(shadowBrush, CreateArrowObject());
        }
    }
}
