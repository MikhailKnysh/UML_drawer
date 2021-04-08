using ArrowLine.Arrow;
using ArrowLine.Line;
using System.Drawing;

namespace ArrowLine
{
    class AgregationStartArrow : AbstractArrow
    {
        public override void Draw(Pen pen, Graphics graphics)
        {
            AbstractArrow line = new SolidLine(_startPoint, _endPoint);
            line.Draw(pen, graphics);

            AbstractArrow arrowCap = new CustomOpenCapArrow(_startPoint, _endPoint);
            arrowCap.Draw(pen, graphics);

            AbstractArrow arrowCapRhomb = new CustomWhiteCapRhombStart(_startPoint, _endPoint);
            arrowCapRhomb.Draw(pen, graphics);
        }
    }
}
