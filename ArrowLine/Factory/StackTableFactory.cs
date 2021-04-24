using ArrowLine.Abstract;
using ArrowLine.Table;

namespace ArrowLine.Factory
{
    class StackTableFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new StackTable(FigureType.Table);
        }
    }
}
