using System.Drawing;
using System.Drawing.Drawing2D;

namespace ArrowLine.Line
{
    public class DashLine : AbstractLine
    {
        public DashLine(Pen pen, Point startPoint, Point endPoint, Graphics graphics)
        {
            _pen = pen;
            _startPoint = startPoint;
            _endPoint = endPoint;
            _graphics = graphics;
        }

        public override void DrawLine()
        {
            _pen.DashStyle = DashStyle.Dash;
            _graphics.DrawLines(_pen, GetPoints());
        }

        protected override Point[] GetPoints()
        {
            return new Point[] {
                _startPoint,
                new Point(_startPoint.X, _endPoint.Y),
                _endPoint
            };
        }
    }
}
