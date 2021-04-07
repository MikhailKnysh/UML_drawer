using System.Drawing;

namespace ArrowLine.Line
{
    public class SolidLine : AbstractArrow
    {
        public SolidLine(Pen pen, Point startPoint, Point endPoint, Graphics graphics)
        {
            _pen = pen;
            _startPoint = startPoint;
            _endPoint = endPoint;
            this.graphics = graphics;
        }

        public override void Draw()
        {
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
