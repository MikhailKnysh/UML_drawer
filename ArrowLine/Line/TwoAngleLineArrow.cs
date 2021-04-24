using ArrowLine.Abstract;
using System.Drawing;

namespace ArrowLine.Line
{
    class TwoAngleLineArrow : AbstractLine
    {
        //public TwoAngleLineArrow(Point startPoint, Point endPoint)
        //{
        //    _startPoint = startPoint;
        //    _endPoint = endPoint;
        //}

        public override Point[] CreateArrowLine()
        {
            int midlle = (startPoint.X + endPoint.X) / 2;
            
            return new Point[] {
                startPoint,
                new Point(midlle, startPoint.Y),
                new Point(midlle, endPoint.Y),
                endPoint
            };
        }

        public override void Draw()
        {
            singltone.Graphics.DrawLines(pen, CreateArrowLine());
        }
    }
}
