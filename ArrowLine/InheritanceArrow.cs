using ArrowLine.Line;
using System;
using System.Collections.Generic;
using System.Drawing;
namespace ArrowLine.Arrow
{
    class InheritanceArrow : AbstractArrow
    {
        public InheritanceArrow()
        {
            _pen = new Pen(Color.Black, 2);
        }
      

        public override void Draw(Graphics graphics)
        {
            AbstractArrow line = new SolidLine(_pen, _startPoint, _endPoint);
            line.Draw(graphics);
            AbstractArrow arrowCap = new CustomCloseCap(_pen, _startPoint, _endPoint);
            arrowCap.Draw(graphics);
        }
    }
}
