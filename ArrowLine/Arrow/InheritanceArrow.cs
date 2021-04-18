using ArrowLine.CapArrow;
using ArrowLine.Line;
using System.Drawing;
using System;

namespace ArrowLine.Arrow
{
    class InheritanceArrow : AbstractFigure
    {
        public override void Draw()
        {
            Delta();

            AbstractLine line = new SolidLineArrow(startPoint, endPoint);
            line.Draw();

            AbstractArrowCap arrowCap = new CloseCapArrow(startPoint, endPoint);
            arrowCap.Draw();
        }
    }
}
