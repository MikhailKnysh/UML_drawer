using ArrowLine.Table;

namespace ArrowLine
{
    public class InterfaceTableFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new InterfaceTable(FigureType.Table);
        }
    }
}
