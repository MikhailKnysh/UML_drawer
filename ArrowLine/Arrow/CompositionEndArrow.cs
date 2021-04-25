using ArrowLine.CapArrow;
using ArrowLine.Line;
using System.Drawing;
using System;
using ArrowLine.Abstract;

namespace ArrowLine.Arrow
{
    class CompositionEndArrow : AbstractFigure
    {
        public CompositionEndArrow(FigureType type)
        {
            Type = type;
        }
        public override void Draw()
        {
            Delta();

            AbstractLine line = new SolidLineArrow(startPoint, endPoint);
            line.Draw();

            
            AbstractFigure arrowCapRhomb = new BlackRhombEndCapArrow(startPoint, endPoint);
            arrowCapRhomb.Draw();
        }
    }
}
