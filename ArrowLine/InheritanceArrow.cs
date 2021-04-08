using ArrowLine.Line;
using System;
using System.Collections.Generic;
using System.Drawing;
namespace ArrowLine.Arrow
{
    class InheritanceArrow : AbstractArrow
    {
        public InheritanceArrow(Pen pen)
        {
            _pen = pen;
        }
      

        public override void Draw(Graphics graphics)
        {
            AbstractArrow line = new SolidLine(_pen, _startPoint, _endPoint);
            line.Draw(graphics);
            AbstractArrow arrowCap = new CustomCloseCap(_pen, _startPoint, _endPoint);
            arrowCap.Draw(graphics);
        }

        public override Point[] CreateArrowObject()
        {
            throw new NotImplementedException();
        }
    }
}
