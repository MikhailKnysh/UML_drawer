using ArrowLine.CapArrow;
using ArrowLine.Line;

namespace ArrowLine.Arrow
{
    class AssociationArrow : AbstractFigure
    {
        public override void Draw()
        {
            Delta();

            AbstractLine line = new SolidLineArrow(startPoint, endPoint);
            line.Draw();

            AbstractArrowCap arrowCap = new OpenCapArrow(startPoint, endPoint);
            arrowCap.Draw();
        }
    }
}
