using UMLDrawer.Abstract;
using UMLDrawer.Arrow;
using UMlDrawer.Abstract;

namespace UMLDrawer.Factory
{
    public class AggregationEndArrowFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new AggregationEndArrow(FigureType.Arrow);
        }
    }
}
