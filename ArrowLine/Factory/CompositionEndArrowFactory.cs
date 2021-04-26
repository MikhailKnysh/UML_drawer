using UMlDrawer.Abstract;
using UMLDrawer.Abstract;
using UMLDrawer.Arrow;

namespace UMLDrawer.Factory
{
    public class CompositionEndArrowFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new CompositionEndArrow(FigureType.Arrow);
        }
    }
}
