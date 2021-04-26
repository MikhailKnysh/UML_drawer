using UMLDrawer.Arrow;
using UMLDrawer.Abstract;
using UMlDrawer.Abstract;

namespace UMLDrawer.Factory
{
    public class AssociationArrowFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new AssociationArrow(FigureType.Arrow);
        }
    }
}
