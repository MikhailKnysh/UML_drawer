using ArrowLine.Arrow;
using ArrowLine.Abstract;
using UMlDrawer.Abstract;

namespace ArrowLine.Factory
{
    public class AssociationArrowFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new AssociationArrow(FigureType.Arrow);
        }
    }
}
