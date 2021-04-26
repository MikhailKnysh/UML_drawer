using UMlDrawer.Abstract;
using ArrowLine.Abstract;
using ArrowLine.Arrow;

namespace ArrowLine.Factory
{
    public class CompositionEndArrowFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new CompositionEndArrow(FigureType.Arrow);
        }
    }
}
