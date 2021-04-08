using ArrowLine.Arrow;
using ArrowLine.Line;
using System.Drawing;

namespace ArrowLine
{
    class AgregationStartArrow : AbstractArrow
    {
        public AgregationStartArrow()
        {
            _pen = new Pen(Color.Black, 2);
        }

        public override void Draw(Graphics graphics)
        {
            AbstractArrow line = new SolidLine(_pen, _startPoint, _endPoint);
            line.Draw(graphics);

            AbstractArrow arrowCap = new CustomOpenCapArrow(_pen, _startPoint, _endPoint);
            arrowCap.Draw(graphics);

            AbstractArrow arrowCapRhomb = new CustomWhiteCapRhombStart(_pen, _startPoint, _endPoint);
            arrowCapRhomb.Draw(graphics);
        }
    }
}
