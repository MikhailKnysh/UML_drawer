using ArrowLine.CapArrow;
using ArrowLine.Line;
using System.Drawing;
using System;
using ArrowLine.Abstract;

namespace ArrowLine.Arrow
{
    class CompositionStartArrow : AbstractFigure
    {
        public CompositionStartArrow(FigureType type)
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

            AbstractFigure arrowCapRhomb = new BlackRhombStartCapArrow(startPoint, endPoint);
            arrowCapRhomb.Draw();
        }
    }
}
