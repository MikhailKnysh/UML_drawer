using UMlDrawer.Abstract;
using UMLDrawer.Abstract;
using UMLDrawer.CapArrow;
using UMLDrawer.Line;

namespace UMLDrawer.Arrow
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
