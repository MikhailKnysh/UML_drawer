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
            Pen pen = new Pen(singltone.Color, singltone.PenWidth);
            pen.DashStyle = DashStyle.Dash;
            singltone.Graphics.DrawLines(pen, CreateArrowLine());
        }
    }
}
