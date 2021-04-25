using ArrowLine.CapArrow;
using ArrowLine.Line;
using System.Drawing;
using System;
using ArrowLine.Abstract;

namespace ArrowLine.Arrow
{
    class AgregationStartArrow : AbstractFigure
    {
        public AgregationStartArrow(FigureType type)
        {
            Type = type;
        }
        public override void Draw()
        {
            Delta();

            AbstractLine line = new SolidLineArrow(startPoint, endPoint);
            line.Draw();

            AbstractArrowCap arrowCap = new OpenCapArrow(startPoint, endPoint);
            arrowCap.Draw();

            AbstractArrowCap arrowCapRhomb = new WhiteRhombStartCapArrow(startPoint, endPoint);
            arrowCapRhomb.Draw();
        }
    }
}
