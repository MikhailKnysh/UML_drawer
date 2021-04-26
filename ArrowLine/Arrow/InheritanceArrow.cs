using UMLDrawer.CapArrow;
using UMLDrawer.Line;
using UMLDrawer.Abstract;
using UMlDrawer.Abstract;

namespace UMLDrawer.Arrow
{
    public class InheritanceArrow : AbstractFigure
    {
        public InheritanceArrow(FigureType type)
        {
            Type = type;
        }

        public override void Draw()
        {
            SetDelta();

            AbstractLine line = new SolidLine(StartPoint, EndPoint);
            line.Draw();

            AbstractCapArrow arrowCap = new CloseCapArrow(StartPoint, EndPoint);
            arrowCap.Draw();

        }
    }
}
