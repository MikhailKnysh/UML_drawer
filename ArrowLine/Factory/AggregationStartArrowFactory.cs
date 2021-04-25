using ArrowLine.Abstract;
using ArrowLine.Arrow;

namespace ArrowLine.Factory
{
    public class AggregationStartArrowFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new AggregationStartArrow(FigureType.Arrow);
        }
    }
}
