using UMLDrawer.CapArrow;
using UMLDrawer.Line;
using UMLDrawer.Abstract;
using UMlDrawer.Abstract;

namespace UMLDrawer.Arrow
{
    public class CompositionStartArrow : AbstractFigure
    {
        public CompositionStartArrow(FigureType type)
        {
            Type = type;
        }

        public override void Draw()
        {
            SetDelta();

            AbstractLine line = new SolidLine(StartPoint, EndPoint);
            line.Draw();

            AbstractCapArrow arrowCap = new OpenCapArrow(StartPoint, EndPoint);
            arrowCap.Draw();

            AbstractCapArrow arrowCapRhomb = new BlackRhombStartCapArrow(StartPoint, EndPoint);
            arrowCapRhomb.Draw();
        }
    }
}
