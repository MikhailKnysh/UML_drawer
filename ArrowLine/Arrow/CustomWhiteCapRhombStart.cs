using System.Drawing;

namespace ArrowLine.Arrow
{
    public class CustomWhiteCapRhombStart : AbstractArrow, IArrowCap
    {
        public CustomWhiteCapRhombStart(Pen pen, Point startPoint, Point endPoint)
        {
            _pen = pen;
            _startPoint = startPoint;
            _endPoint = endPoint;
        }

        public Point[] CreateArrowObject()
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

        public override void Draw(Graphics graphics)
        {
            SolidBrush shadowBrush = new SolidBrush(Color.White);

            graphics.DrawPolygon(_pen, CreateArrowObject());
            graphics.FillPolygon(shadowBrush, CreateArrowObject());
        }
    }
}
