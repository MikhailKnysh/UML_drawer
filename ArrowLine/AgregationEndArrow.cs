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
        public AgregationEndArrow()
        {
            _pen = new Pen(Color.Black, 2);
        }

        public override void Draw(Graphics graphics)
        {
            AbstractArrow line = new SolidLine(_pen, _startPoint, _endPoint);
            line.Draw(graphics);

            AbstractArrow arrowCapRhomb = new CustomWhiteCapRhombEnd(_pen, _startPoint, _endPoint);
            arrowCapRhomb.Draw(graphics);
        }
    }
}
