using UMlDrawer.Abstract;
using UMLDrawer.Abstract;
using UMLDrawer.Table;

namespace UMLDrawer.Factory
{
    public class InterfaceTableFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new InterfaceTable(FigureType.Table);
        }
    }
}
