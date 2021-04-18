using ArrowLine.CapArrow;
using ArrowLine.Line;
using System.Drawing;
using System;

namespace ArrowLine.Arrow
{
    class AssociationArrow : AbstractFigure
    {
        public override void Draw()
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
            line.Draw();

            AbstractArrowCap arrowCap = new OpenCapArrow(_startPoint, _endPoint);
            arrowCap.Draw();
        }
    }
}
