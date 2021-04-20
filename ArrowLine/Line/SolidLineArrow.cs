using System.Drawing;

namespace ArrowLine.Line
{
    public class SolidLineArrow : AbstractLine
    {
        public SolidLineArrow(Point startPoint, Point endPoint)
        {
            this.startPoint = startPoint;
            this.endPoint = endPoint;
        }

        public override void Draw()
        {
            singltone.Graphics.DrawLines(singltone.pen, CreateArrowLine());
           
        }
    }
}
