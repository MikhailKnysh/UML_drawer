using System.Drawing;

namespace ArrowLine
{
    public abstract class AbstractLine: AbstractFigure
    {
        //public Point _endPoint;

        public abstract Point[] CreateArrowLine();
    }
}
