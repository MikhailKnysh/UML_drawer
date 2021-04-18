using System.Drawing;

namespace ArrowLine.CapArrow
{
    public class BlackRhombStartCapArrow : AbstractArrowCap
    {
        public BlackRhombStartCapArrow(Point startPoint, Point endPoint)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
        }

        public override Point[] CreateArrowObject()
        {
            Point[] _CustomCapArrow = new Point[]
            {
                new Point(_startPoint.X, _startPoint.Y),
                new Point(_startPoint.X, _startPoint.Y),
                _startPoint,
                new Point(_startPoint.X, _startPoint.Y),
                _startPoint,
            };

            if (_startPoint.X < _endPoint.X && _startPoint.Y == _endPoint.Y)
            {

                _CustomCapArrow[1].X += _arrowSize;
                _CustomCapArrow[1].Y -= _arrowSize;

                _CustomCapArrow[2].X += 2 * _arrowSize;

                _CustomCapArrow[3].X += _arrowSize;
                _CustomCapArrow[3].Y += _arrowSize;
            }
            else if (_startPoint.Y > _endPoint.Y && _startPoint.X == _endPoint.X)
            {
                _CustomCapArrow[1].X -= _arrowSize;
                _CustomCapArrow[1].Y -= _arrowSize;

                _CustomCapArrow[2].Y -= 2 * _arrowSize;

                _CustomCapArrow[3].X += _arrowSize;
                _CustomCapArrow[3].Y -= _arrowSize;
            }
            else if (_startPoint.X > _endPoint.X && _startPoint.Y == _endPoint.Y)
            {
                _CustomCapArrow[1].X -= _arrowSize;
                _CustomCapArrow[1].Y -= _arrowSize;

                _CustomCapArrow[2].X -= 2 * _arrowSize;

                _CustomCapArrow[3].X -= _arrowSize;
                _CustomCapArrow[3].Y += _arrowSize;
            }
            else
            {
                _CustomCapArrow[1].X += _arrowSize;
                _CustomCapArrow[1].Y += _arrowSize;

                _CustomCapArrow[2].Y += 2 * _arrowSize;

                _CustomCapArrow[3].X -= _arrowSize;
                _CustomCapArrow[3].Y += _arrowSize;
            }

            return _CustomCapArrow;
        }

        public override void Draw()
        {
            SolidBrush shadowBrush = new SolidBrush(singltone.pen.Color);

            singltone.graphics.DrawPolygon(singltone.pen, CreateArrowObject());
            singltone.graphics.FillPolygon(shadowBrush, CreateArrowObject());
        }
    }
}
