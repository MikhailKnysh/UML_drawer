using System.Drawing;

namespace ArrowLine.Line
{
    public class SolidLine : AbstractArrow
    {
        public SolidLine(Pen pen)
        {
            _pen = pen;
        }

        public override void Draw(Graphics graphics)
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
