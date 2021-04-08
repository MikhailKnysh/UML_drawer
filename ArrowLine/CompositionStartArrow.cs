using ArrowLine.Arrow;
using ArrowLine.Line;
using System.Drawing;

namespace ArrowLine
{
    class CompositionStartArrow: AbstractArrow
    {
        public CompositionStartArrow()
        {
            _pen = new Pen(Color.Black, 2);
        }


        public override void Draw(Graphics graphics)
        {
            AbstractArrow line = new SolidLine(_pen, _startPoint, _endPoint);
            line.Draw(graphics);
            AbstractArrow arrowCap = new CustomOpenCapArrow(_pen, _startPoint, _endPoint);
            arrowCap.Draw(graphics);
            AbstractArrow arrowCapRhomb = new CustomBlackCapRhombStart(_pen, _startPoint, _endPoint);
            arrowCapRhomb.Draw(graphics);
        }
    }
}
