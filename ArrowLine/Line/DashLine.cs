using UMLDrawer.Abstract;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace UMLDrawer.Line
{
    public class DashLine : AbstractLine
    {
        public DashLine(Point startPoint, Point endPoint)
        {
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
        }
        public override void Draw()
        {
            pen.DashStyle = DashStyle.Dash;
            GraphicsPictureBox.Graphics.DrawLines(pen, CreateArrowLine());
        }
    }
}
