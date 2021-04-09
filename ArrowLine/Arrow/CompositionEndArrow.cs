using ArrowLine.CapArrow;
using ArrowLine.Line;
using System.Drawing;

namespace ArrowLine.Arrow
{
    class CompositionEndArrow : AbstractArrow
    {
        public override void Draw(Pen pen, Graphics graphics)
        {
            AbstractArrow line = new SolidLineArrow(_startPoint, _endPoint);
            line.Draw(pen, graphics);

            AbstractArrow arrowCap = new OpenCapArrow(_startPoint, _endPoint);
            arrowCap.Draw(pen, graphics);

            AbstractArrow arrowCapRhomb = new BlackRhombEndCapArrow(_startPoint, _endPoint);
            arrowCapRhomb.Draw(pen, graphics);
        }
    }
}
