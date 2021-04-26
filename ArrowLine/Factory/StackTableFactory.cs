using UMlDrawer.Abstract;
using ArrowLine.Abstract;
using ArrowLine.Table;

namespace ArrowLine.Factory
{
    public class StackTableFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new StackTable(FigureType.Table);
        }
    }
}
