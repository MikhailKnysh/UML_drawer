using ArrowLine.Arrow;

namespace ArrowLine
{
    public class AgregationStartArrowFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new AgregationStartArrow(FigureType.Arrow);
        }
    }
}
