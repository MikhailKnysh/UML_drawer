using System.Drawing;

namespace ArrowLine
{
    public abstract class AbstractArrowCap: AbstractArrow
    {
        protected int _arrowSize = 10;

        public abstract Point[] CreateArrowObject();

    }
}
