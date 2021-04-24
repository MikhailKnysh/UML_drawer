using System.Drawing;

namespace ArrowLine.CapArrow
{
    public class WhiteRhombStartCapArrow : AbstractArrowCap
    {
        public WhiteRhombStartCapArrow(Point startPoint, Point endPoint)
        {
            this.startPoint = startPoint;
            this.endPoint = endPoint;
        }

        public override Point[] CreateArrowObject()
        {
            Point[] _CustomCapArrow = new Point[]
            {
                new Point(startPoint.X, startPoint.Y),
                new Point(startPoint.X, startPoint.Y),
                startPoint,
                new Point(startPoint.X, startPoint.Y),
                startPoint,
            };

            if (startPoint.X < endPoint.X && startPoint.Y == endPoint.Y)
            {

                _CustomCapArrow[1].X += _arrowSize;
                _CustomCapArrow[1].Y -= _arrowSize;

                _CustomCapArrow[2].X += 2 * _arrowSize;

                _CustomCapArrow[3].X += _arrowSize;
                _CustomCapArrow[3].Y += _arrowSize;
            }
            else if (startPoint.Y > endPoint.Y && startPoint.X == endPoint.X)
            {
                _CustomCapArrow[1].X -= _arrowSize;
                _CustomCapArrow[1].Y -= _arrowSize;

                _CustomCapArrow[2].Y -= 2 * _arrowSize;

                _CustomCapArrow[3].X += _arrowSize;
                _CustomCapArrow[3].Y -= _arrowSize;
            }
            else if (startPoint.X > endPoint.X && startPoint.Y == endPoint.Y)
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
            SolidBrush shadowBrush = new SolidBrush(Color.White);

            GraficPictureBox.Graphics.DrawPolygon(pen, CreateArrowObject());
            GraficPictureBox.Graphics.FillPolygon(shadowBrush, CreateArrowObject());
        }
    }
}
