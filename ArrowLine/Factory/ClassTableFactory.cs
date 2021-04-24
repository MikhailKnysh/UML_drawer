using ArrowLine.Abstract;
using ArrowLine.Factory;
using ArrowLine.Table;

namespace ArrowLine.Factory
{
    class ClassTableFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new ClassTable(FigureType.Table);
        }
    }
}
