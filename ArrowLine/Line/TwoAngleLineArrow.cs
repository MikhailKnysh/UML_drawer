using System.Drawing;

namespace ArrowLine.Line
{
    class TwoAngleLineArrow : AbstractLine
    {
        public TwoAngleLineArrow(Point startPoint, Point endPoint)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
        }

        public override Point[] CreateArrowLine()
        {
            int midlle = (_startPoint.X + _endPoint.X) / 2;
            
            return new Point[] {
                _startPoint,
                new Point(midlle, _startPoint.Y),
                new Point(midlle, _endPoint.Y),
                _endPoint
            };
        }

        public override void Draw()
        {
            singltone.graphics.DrawLines(singltone.pen, CreateArrowLine());
        }
    }
}
