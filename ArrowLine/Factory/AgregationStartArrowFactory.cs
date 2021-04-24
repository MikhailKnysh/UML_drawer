using ArrowLine.Abstract;
using ArrowLine.Arrow;

namespace ArrowLine.Factory
{
    public class AgregationStartArrowFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new AgregationStartArrow(FigureType.Arrow);
        }
    }
}
