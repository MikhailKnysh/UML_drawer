using ArrowLine.Abstract;
using ArrowLine.Arrow;
using UMlDrawer.Abstract;

namespace ArrowLine.Factory
{
    public class CompositionStartArrowFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new CompositionStartArrow(FigureType.Arrow);
        }
    }
}
