using ArrowLine.Table;

namespace ArrowLine
{
    class ClassTableFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new ClassTable();
        }
    }
}
