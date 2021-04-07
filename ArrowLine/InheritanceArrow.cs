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
        public InheritanceArrow(Pen pen, Point startPoint, Point endPoint, Graphics graphics)
        {
            _pen = pen;
            _startPoint = startPoint;
            _endPoint = endPoint;
            this.graphics = graphics;
        }

        public override void Draw()
        {
            AbstractArrow line = new SolidLine(_pen, _startPoint, _endPoint, graphics);
            line.Draw();
            AbstractArrow arrowCap = new CustomCloseCap(_pen, _startPoint, _endPoint, graphics);
            arrowCap.Draw();
        }

        protected override Point[] CreateArrowObject()
        {
            throw new NotImplementedException();
        }
    }
}
