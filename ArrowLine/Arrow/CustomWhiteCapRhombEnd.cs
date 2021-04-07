using System.Drawing;

namespace ArrowLine.Arrow
{
    public class CustomWhiteCapRhombEnd : AbstractArrowCap
    {
        public CustomWhiteCapRhombEnd(Graphics graphics, Pen pen, Point startPoint, Point endPoint)
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
        }

        public override void DrawCap()
        {
            SolidBrush shadowBrush = new SolidBrush(Color.White);

            CreateArrowCap();

            _graphics.DrawPolygon(_pen, _CustomCapArrow);
            _graphics.FillPolygon(shadowBrush, _CustomCapArrow);
        }
    }
}
