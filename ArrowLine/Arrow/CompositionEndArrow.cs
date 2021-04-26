using UMLDrawer.CapArrow;
using UMLDrawer.Line;
using UMLDrawer.Abstract;
using UMlDrawer.Abstract;

namespace UMLDrawer.Arrow
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
