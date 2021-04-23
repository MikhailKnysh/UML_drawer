using ArrowLine.CapArrow;
using ArrowLine.Line;

namespace ArrowLine.Arrow
{
    public class AgregationEndArrow : AbstractFigure
    {
        public AgregationEndArrow(FigureType type)
        {
            Type = type;
        }
        public override void Draw()
        {
            Delta();

            AbstractLine line = new SolidLineArrow(startPoint,endPoint);
            line.Draw();

            AbstractArrowCap arrowCapRhomb = new WhiteRhombEndCapArrow(startPoint, endPoint);
            arrowCapRhomb.Draw();
        }
    }
}
