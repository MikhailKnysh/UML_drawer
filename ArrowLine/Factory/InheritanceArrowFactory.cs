using UMLDrawer.Abstract;
using UMLDrawer.Arrow;
using UMlDrawer.Abstract;

namespace UMLDrawer.Factory
{
    public class InheritanceArrowFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new InheritanceArrow(FigureType.Arrow);
        }
    }
}
