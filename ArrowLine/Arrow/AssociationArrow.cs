using UMlDrawer.Abstract;
using ArrowLine.Abstract;
using ArrowLine.CapArrow;
using ArrowLine.Line;

namespace ArrowLine.Arrow
{
     public class AssociationArrow : AbstractFigure
     {
        public AssociationArrow(FigureType type)
        {
            Type = type;
        }

        public override void Draw()
        {
            SetDelta();

            AbstractCapArrow arrowCap = new OpenCapArrow(StartPoint, EndPoint);
            arrowCap.Draw();

            AbstractLine line = new SolidLine(StartPoint, EndPoint);
            line.Draw();
        }
     }
}
