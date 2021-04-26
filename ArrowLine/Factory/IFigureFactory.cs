using UMLDrawer.Abstract;

namespace UMLDrawer.Factory
{
    public interface IFigureFactory
    {
        AbstractFigure CreateFigure();
    }
}
