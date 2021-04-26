using ArrowLine.Abstract;
using ArrowLine.CapArrow;
using ArrowLine.Line;
using UMlDrawer.Abstract;

namespace ArrowLine.Arrow
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
