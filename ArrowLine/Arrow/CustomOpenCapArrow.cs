using System.Drawing;

namespace ArrowLine.Arrow
{
    public class CustomOpenCapArrow : AbstractArrow
    {
        public CustomOpenCapArrow(Pen pen)//
        {
            _pen = pen;
        }

        protected override Point[] CreateArrowObject()
        {
           Point[] _CustomCapArrow = new Point[]
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

            return _CustomCapArrow;
        }

        public override void Draw()
        {
            CreateArrowObject();

            graphics.DrawLines(_pen, CreateArrowObject());
        }
    }
}
