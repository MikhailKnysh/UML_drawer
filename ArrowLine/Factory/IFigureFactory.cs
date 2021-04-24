using System.Drawing;

namespace ArrowLine
{
    public interface IFigureFactory
    {
        AbstractFigure CreateFigure();
    }
}
