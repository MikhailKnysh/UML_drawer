using System.Drawing;
using System.Drawing.Drawing2D;

namespace ArrowLine.Line
{
    public class DashLine : AbstractArrow, ILine
    {
        public DashLine(Pen pen, Point startPoint, Point endPoint)
        {
            _pen = pen;
            _startPoint = startPoint;
            _endPoint = endPoint;
        }

        public override void Draw(Graphics graphics)
        {
            _pen.DashStyle = DashStyle.Dash;
            graphics.DrawLines(_pen, CreateArrowLine());
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
