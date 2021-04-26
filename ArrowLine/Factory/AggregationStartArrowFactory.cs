using UMlDrawer.Abstract;
using UMLDrawer.Abstract;
using UMLDrawer.Arrow;

namespace UMLDrawer.Factory
{
    public class AggregationStartArrowFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new AggregationStartArrow(FigureType.Arrow);
        }
    }
}
