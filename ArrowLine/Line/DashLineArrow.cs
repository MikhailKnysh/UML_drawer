using System.Drawing;
using System.Drawing.Drawing2D;

namespace ArrowLine.Line
{
    public class DashLineArrow : AbstractArrow, ILine
    {
        public DashLineArrow(Point startPoint, Point endPoint)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
        }

        public override void Draw(Pen pen,Graphics graphics)
        {
            pen.DashStyle = DashStyle.Dash;
            graphics.DrawLines(pen, CreateArrowLine());
        }

        public Point[] CreateArrowLine()
        {
            return new Point[] {
                _startPoint,
                new Point(_startPoint.X, _endPoint.Y),
                _endPoint
            };
        }
    }
}
