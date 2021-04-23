using ArrowLine.Table;

namespace ArrowLine
{
    class StackTableFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new StackTable();
        }
    }
}
