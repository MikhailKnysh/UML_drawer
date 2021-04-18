using System.Drawing;
using System.Drawing.Drawing2D;

namespace ArrowLine.Line
{
    public class DashLineArrow : AbstractLine
    {
        public DashLineArrow(Point startPoint, Point endPoint)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
        }

        public override void Draw()
        {
            singltone.pen.DashStyle = DashStyle.Dash;
            singltone.graphics.DrawLines(singltone.pen, CreateArrowLine());
        }

        public override Point[] CreateArrowLine()
        {
            return new Point[] {
                _startPoint,
                new Point(_startPoint.X, _endPoint.Y),
                _endPoint
            };
        }
    }
}
