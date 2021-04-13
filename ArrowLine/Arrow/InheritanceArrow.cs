using ArrowLine.CapArrow;
using ArrowLine.Line;
using System.Drawing;
using System;

namespace ArrowLine.Arrow
{
    class InheritanceArrow : AbstractArrow
    {
        public override void Draw(Pen pen, Graphics graphics)
        {
            if (Math.Abs(_startPoint.X - _endPoint.X) < 20)
            {
                _endPoint.X = _startPoint.X;
            }
            else if (Math.Abs(_startPoint.Y - _endPoint.Y) < 20)
            {
                _endPoint.Y = _startPoint.Y;
            }

            AbstractLine line = new SolidLineArrow(_startPoint, _endPoint);
            line.Draw(pen, graphics);

            AbstractArrowCap arrowCap = new CloseCapArrow(_startPoint, _endPoint);
            arrowCap.Draw(pen, graphics);
        }
    }
}
