using ArrowLine.Arrow;
using ArrowLine.Line;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowLine
{
    class AgregationEndArrow : AbstractArrow
    {
        

        public override void Draw(Pen pen, Graphics graphics)
        {
            AbstractArrow line = new SolidLine(_startPoint, _endPoint);
            line.Draw(pen, graphics);

            AbstractArrow arrowCapRhomb = new CustomWhiteCapRhombEnd(_startPoint, _endPoint);
            arrowCapRhomb.Draw(pen, graphics);
        }
    }
}
