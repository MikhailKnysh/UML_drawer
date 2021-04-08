using ArrowLine.Arrow;
using ArrowLine.Line;
using System;
using System.Drawing;

namespace ArrowLine
{
    public class ImplementationArrow: AbstractArrow
    {
        public ImplementationArrow()
        {
            _pen = new Pen(Color.Black, 2);
        }


        public override void Draw(Graphics graphics)
        {
            AbstractArrow line = new DashLine(_pen, _startPoint, _endPoint);
            line.Draw(graphics);
            AbstractArrow arrowCap = new CustomCloseCap(new Pen(Color.Black,2), _startPoint, _endPoint);
            arrowCap.Draw(graphics);
        }
    }
}
