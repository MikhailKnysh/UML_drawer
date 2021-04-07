using ArrowLine.Line;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowLine.Arrow
{
    class InheritanceArrow : AbstractArrow
    {
        public override void Draw(Graphics graphics)
        {
            AbstractArrow line = new SolidLine(_pen);
            AbstractArrow arrowCap = new CustomCloseCap(_pen);
            line.Draw(graphics);
            arrowCap.Draw(graphics);
        }

        protected override Point[] CreateArrowObject()
        {
            throw new NotImplementedException();
        }
    }
}
