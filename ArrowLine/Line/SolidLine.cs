using ArrowLine.Abstract;
using System.Drawing;

namespace ArrowLine.Line
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
