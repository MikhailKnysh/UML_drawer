using ArrowLine.Line;
using System.Drawing;
namespace ArrowLine.Arrow
{
    class InheritanceArrow : AbstractArrow
    {
        public override void Draw(Pen pen, Graphics graphics)
        {
            AbstractArrow line = new SolidLine(_startPoint, _endPoint);
            line.Draw(pen,graphics);
            AbstractArrow arrowCap = new CustomCloseCap(_startPoint, _endPoint);
            arrowCap.Draw(pen, graphics);
        }
    }
}
