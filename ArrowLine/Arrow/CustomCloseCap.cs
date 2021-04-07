using System.Drawing;

namespace ArrowLine.Arrow
{
    public class CustomCloseCap : AbstractArrow
    {
        public CustomCloseCap(Pen pen, Point startPoint, Point endPoint, Graphics graphics)
        {
            _pen = pen;
            _startPoint = startPoint;
            _endPoint = endPoint;
            this.graphics = graphics;
        }


        protected override Point[] CreateArrowObject()
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

        public override void Draw()
        {
            CreateArrowObject();

            graphics.DrawLines(_pen, CreateArrowObject());
        }
    }
}
