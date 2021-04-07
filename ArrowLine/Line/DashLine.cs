using System.Drawing;
using System.Drawing.Drawing2D;

namespace ArrowLine.Line
{
    public class DashLine : AbstractArrow
    {
        public DashLine(Pen pen, Point startPoint, Point endPoint, Graphics graphics)
        {
            _pen = pen;
            _startPoint = startPoint;
            _endPoint = endPoint;
            this.graphics = graphics;
        }

        public override void Draw()
        {
            _pen.DashStyle = DashStyle.Dash;
            graphics.DrawLines(_pen, CreateArrowObject());
        }

        protected override Point[] CreateArrowObject()
        {
            return new Point[] {
                _startPoint,
                new Point(_startPoint.X, _endPoint.Y),
                _endPoint
            };
        }
    }
}
