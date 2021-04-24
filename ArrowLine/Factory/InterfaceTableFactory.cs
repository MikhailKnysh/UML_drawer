using ArrowLine.Abstract;
using ArrowLine.Table;

namespace ArrowLine.Factory
{
    public class InterfaceTableFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new InterfaceTable(FigureType.Table);
        }
    }
}
