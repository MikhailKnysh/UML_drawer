using ArrowLine.Abstract;
using ArrowLine.CapArrow;
using ArrowLine.Line;

namespace ArrowLine.Arrow
{
     public class AssociationArrow : AbstractFigure
    {
        public AssociationArrow()
        {

        }
        public AssociationArrow(FigureType type)
        {
            Type = type;
        }

        public override void Draw()
        {
            Delta();
            AbstractArrowCap arrowCap = new OpenCapArrow(startPoint, endPoint);
            arrowCap.Draw();

            AbstractLine line = new SolidLineArrow(startPoint, endPoint);
            line.Draw();
        }
    }
}
