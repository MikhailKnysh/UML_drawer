using ArrowLine.Arrow;
using ArrowLine.Line;
using System.Drawing;

namespace ArrowLine
{
    class CompositionStartArrow: AbstractArrow
    {
        public override void Draw(Pen pen,Graphics graphics)
        {
            AbstractArrow line = new SolidLine(_startPoint, _endPoint);
            line.Draw(pen, graphics);
            AbstractArrow arrowCap = new CustomOpenCapArrow(_startPoint, _endPoint);
            arrowCap.Draw(pen, graphics);
            AbstractArrow arrowCapRhomb = new CustomBlackCapRhombStart(_startPoint, _endPoint);
            arrowCapRhomb.Draw(pen, graphics);
        }
    }
}
