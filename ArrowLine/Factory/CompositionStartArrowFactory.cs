using UMLDrawer.Abstract;
using UMLDrawer.Arrow;
using UMlDrawer.Abstract;

namespace UMLDrawer.Factory
{
    public class CompositionStartArrowFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new CompositionStartArrow(FigureType.Arrow);
        }
    }
}
