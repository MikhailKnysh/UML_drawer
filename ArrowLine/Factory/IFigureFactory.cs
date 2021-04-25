using ArrowLine.Abstract;

namespace ArrowLine.Factory
{
    public interface IFigureFactory
    {
        AbstractFigure CreateFigure();
    }
}
