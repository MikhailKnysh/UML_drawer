using UMlDrawer.Abstract;
using UMLDrawer.Abstract;
using UMLDrawer.Arrow;


namespace UMLDrawer.Factory
{
    public class ImplementationArrowFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new ImplementationArrow(FigureType.Arrow);
        }
    }
}
