using UMlDrawer.Abstract;
using UMLDrawer.Abstract;
using UMLDrawer.Table;

namespace UMLDrawer.Factory
{
    public class StackTableFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new StackTable(FigureType.Table);
        }
    }
}
