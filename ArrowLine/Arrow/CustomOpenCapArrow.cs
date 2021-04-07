using System.Drawing;

namespace ArrowLine.Arrow
{
    public class CustomOpenCapArrow : AbstractArrowCap
    {
        public CustomOpenCapArrow(Graphics graphics, Pen pen, Point startPoint, Point endPoint)
        {
            _graphics = graphics;
            _pen = pen;
            _startPoint = startPoint;
            _endPoint = endPoint;
        }

        protected override void CreateArrowCap()
        {
            _CustomCapArrow = new Point[]
             {
                new Point(_endPoint.X, _endPoint.Y),
                _endPoint,
                new Point(_endPoint.X, _endPoint.Y)
             };

            if (_startPoint.X < _endPoint.X)
            {
                _CustomCapArrow[0].Y -= _arrowSize;
                _CustomCapArrow[0].X -= _arrowSize;

                _CustomCapArrow[2].Y += _arrowSize;
                _CustomCapArrow[2].X -= _arrowSize;
            }
            else if (_startPoint.Y > _endPoint.Y && _startPoint.X == _endPoint.X)
            {
                _CustomCapArrow[0].Y += _arrowSize;
                _CustomCapArrow[0].X -= _arrowSize;

                _CustomCapArrow[2].Y += _arrowSize;
                _CustomCapArrow[2].X += _arrowSize;
            }
            else if (_startPoint.X > _endPoint.X)
            {
                _CustomCapArrow[0].Y -= _arrowSize;
                _CustomCapArrow[0].X += _arrowSize;

                _CustomCapArrow[2].Y += _arrowSize;
                _CustomCapArrow[2].X += _arrowSize;
            }
            else
            {
                _CustomCapArrow[0].Y -= _arrowSize;
                _CustomCapArrow[0].X += _arrowSize;

                _CustomCapArrow[2].Y -= _arrowSize;
                _CustomCapArrow[2].X -= _arrowSize;
            }
        }

        public override void DrawCap()
        {
            CreateArrowCap();

            _graphics.DrawLines(_pen, _CustomCapArrow);
        }
    }
}
