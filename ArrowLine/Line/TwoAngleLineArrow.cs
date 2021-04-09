using System.Drawing;

namespace ArrowLine.Line
{
    class TwoAngleLineArrow : AbstractArrow, ILine
    {
        public TwoAngleLineArrow(Point startPoint, Point endPoint)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
        }

        public Point[] CreateArrowLine()
        {
            int midlle = (_startPoint.X + _endPoint.X) / 2;
            
            return new Point[] {
                _startPoint,
                new Point(midlle, _startPoint.Y),
                new Point(midlle, _endPoint.Y),
                _endPoint
            };
        }

        public override void Draw(Pen pen, Graphics graphics)
        {
            graphics.DrawLines(pen, CreateArrowLine());
        }
    }
}
