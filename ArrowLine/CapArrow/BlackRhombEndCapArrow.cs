using System.Drawing;

namespace ArrowLine.CapArrow
{
    public class BlackRhombEndCapArrow : AbstractArrowCap
    {
        public BlackRhombEndCapArrow(Point startPoint, Point endPoint)
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
                _CustomCapArrow[1].X -= _arrowSize;
                _CustomCapArrow[1].Y -= _arrowSize;

                _CustomCapArrow[2].X -= 2 * _arrowSize;

                _CustomCapArrow[3].X -= _arrowSize;
                _CustomCapArrow[3].Y += _arrowSize;
            }
            else if (startPoint.Y > endPoint.Y && startPoint.X == endPoint.X)
            {
                _CustomCapArrow[1].X += _arrowSize;
                _CustomCapArrow[1].Y += _arrowSize;

                _CustomCapArrow[2].Y += 2 * _arrowSize;

                _CustomCapArrow[3].X -= _arrowSize;
                _CustomCapArrow[3].Y += _arrowSize;
            }
            else if (startPoint.X > endPoint.X)
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

        public override void Draw()
        {
            SolidBrush shadowBrush = new SolidBrush(pen.Color);

            GraficPictureBox.Graphics.DrawPolygon(pen, CreateArrowObject());
            GraficPictureBox.Graphics.FillPolygon(shadowBrush, CreateArrowObject());
        }
    }
}
