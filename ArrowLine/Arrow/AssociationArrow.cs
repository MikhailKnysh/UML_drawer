using ArrowLine.CapArrow;
using ArrowLine.Line;
using System.Drawing;
using System;

namespace ArrowLine.Arrow
{
     public class AssociationArrow : AbstractFigure
    {
        AbstractLine line;
        AbstractArrowCap arrowCap;

        public AssociationArrow(FigureType type)
        {
            line = new SolidLineArrow(startPoint, endPoint);
            arrowCap = new OpenCapArrow(startPoint, endPoint);
            Type = type;
        }

        public override void Draw()
        {
            Delta();

            singltone.Graphics.DrawLines(singltone.pen, line.CreateArrowLine());
            singltone.Graphics.DrawLines(singltone.pen, arrowCap.CreateArrowObject());
        }
    }
}
