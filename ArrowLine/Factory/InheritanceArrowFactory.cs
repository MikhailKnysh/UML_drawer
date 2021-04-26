using ArrowLine.Abstract;
using ArrowLine.Arrow;
using UMlDrawer.Abstract;

namespace ArrowLine.Factory
{
    public class InheritanceArrowFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new InheritanceArrow(FigureType.Arrow);
        }
    }
}
