using ArrowLine.CapArrow;
using ArrowLine.Line;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ArrowLine.Arrow
{
    public class ImplementationArrow : AbstractArrow
    {
        public override void Draw(Pen pen, Graphics graphics)
        {
            AbstractArrow arrowCap = new CloseCapArrow(_startPoint, _endPoint);
            arrowCap.Draw(pen, graphics);

            AbstractArrow line = new DashLineArrow(_startPoint, _endPoint);
            line.Draw(pen, graphics);
            pen.DashStyle = DashStyle.Solid;
        }
    }
}
