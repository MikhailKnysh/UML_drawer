using UMlDrawer.Abstract;
using UMLDrawer.Abstract;
using UMLDrawer.Table;

namespace UMLDrawer.Factory
{
    public class ClassTableFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new ClassTable(FigureType.Table);
        }
    }
}
