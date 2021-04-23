using ArrowLine.CapArrow;
using ArrowLine.Line;
using System.Drawing;
using System;

namespace ArrowLine.Arrow
{
    class AssociationArrow : AbstractFigure
    {
        AbstractLine line;
        AbstractArrowCap arrowCap;

        public AssociationArrow(FigureType type)
        {
            Type = type;
        }

        public override void Draw()
        {
            Delta();

            line = new SolidLineArrow(startPoint, endPoint);
            line.Draw();
            arrowCap = new OpenCapArrow(startPoint, endPoint);
            arrowCap.Draw();
        }
    }
}
