using ArrowLine.Abstract;
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
            pen.DashStyle = DashStyle.Dash;
            GraficPictureBox.Graphics.DrawLines(pen, CreateArrowLine());
        }
    }
}
