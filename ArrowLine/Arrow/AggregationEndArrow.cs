using UMLDrawer.Abstract;
using UMLDrawer.CapArrow;
using UMLDrawer.Line;
using UMlDrawer.Abstract;

namespace UMLDrawer.Arrow
{
    public class AggregationEndArrow : AbstractFigure
    {
        public AggregationEndArrow(FigureType type)
        {
            Type = type;
        }

        public override void Draw()
        {
            SetDelta();

            AbstractLine line = new SolidLine(StartPoint,EndPoint);
            line.Draw();

            AbstractCapArrow arrowCapRhomb = new WhiteRhombEndCapArrow(StartPoint, EndPoint);
            arrowCapRhomb.Draw();
        }
    }
}
