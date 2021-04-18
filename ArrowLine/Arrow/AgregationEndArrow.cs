using ArrowLine.CapArrow;
using ArrowLine.Line;
using System.Drawing;
using System;

namespace ArrowLine.Arrow
{
    class AgregationEndArrow : AbstractFigure
    {
        public override void Draw()
        {
            Delta();

            AbstractLine line = new SolidLineArrow(startPoint,endPoint);
            line.Draw();

            AbstractArrowCap arrowCapRhomb = new WhiteRhombEndCapArrow(startPoint, endPoint);
            arrowCapRhomb.Draw();
        }
    }
}
