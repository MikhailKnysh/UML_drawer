using UMlDrawer.Abstract;
using ArrowLine.Abstract;
using ArrowLine.Arrow;


namespace ArrowLine.Factory
{
    public class ImplementationArrowFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new ImplementationArrow(FigureType.Arrow);
        }
    }
}
