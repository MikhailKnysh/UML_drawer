using UMLDrawer.Abstract;
using System.Drawing;

namespace UMLDrawer.Line
{
    public class SolidLine : AbstractLine
    {
        public SolidLine(Point startPoint, Point endPoint)
        {
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
        }

        public override void Draw()
        {
            GraphicsPictureBox.Graphics.DrawLines(pen, CreateArrowLine());
        }
    }
}
