using ArrowLine.CapArrow;
using ArrowLine.Line;
using ArrowLine.Abstract;
using UMlDrawer.Abstract;

namespace ArrowLine.Arrow
{
    public class AggregationStartArrow : AbstractFigure
    {
        public AggregationStartArrow(FigureType type)
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

            AbstractCapArrow arrowCapRhomb = new WhiteRhombStartCapArrow(StartPoint, EndPoint);
            arrowCapRhomb.Draw();
        }
    }
}
