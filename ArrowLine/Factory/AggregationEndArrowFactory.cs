using ArrowLine.Abstract;
using ArrowLine.Arrow;
using UMlDrawer.Abstract;

namespace ArrowLine.Factory
{
    public class AggregationEndArrowFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new AggregationEndArrow(FigureType.Arrow);
        }
    }
}
