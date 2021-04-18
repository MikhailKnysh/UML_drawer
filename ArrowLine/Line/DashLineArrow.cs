using System.Drawing;
using System.Drawing.Drawing2D;

namespace ArrowLine.Line
{
    public class DashLineArrow : AbstractLine
    {
        public DashLineArrow(Point startPoint, Point endPoint)
        {
            this.startPoint = startPoint;
            this.endPoint = endPoint;
        }
        public override void Draw()
        {
            singltone.pen.DashStyle = DashStyle.Dash;
            singltone.graphics.DrawLines(singltone.pen, CreateArrowLine());
        }
    }
}
