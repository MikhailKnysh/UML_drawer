using System.Drawing;

namespace ArrowLine
{
    public abstract class AbstractArrowCap: AbstractFigure
    {
        protected int _arrowSize = 10;
        public Point _endPoint;

        public abstract Point[] CreateArrowObject();

    }
}
