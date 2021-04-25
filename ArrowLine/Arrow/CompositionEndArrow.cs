using ArrowLine.CapArrow;
using ArrowLine.Line;
using System.Drawing;
using System;
using ArrowLine.Abstract;

namespace ArrowLine.Arrow
{
    public class CompositionEndArrow : AbstractFigure
    {
        public CompositionEndArrow(FigureType type)
        {
            Type = type;
        }

        public override void Draw()
        {
            SetDelta();

            AbstractLine line = new SolidLine(StartPoint, EndPoint);
            line.Draw();
            
            AbstractCapArrow arrowCapRhomb = new BlackRhombEndCapArrow(StartPoint, EndPoint);
            arrowCapRhomb.Draw();
        }
    }
}
