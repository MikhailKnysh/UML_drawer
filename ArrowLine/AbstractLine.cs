using System.Drawing;

namespace ArrowLine
{
    public abstract class AbstractLine: AbstractArrow
    {
        public abstract Point[] CreateArrowLine();
    }
}
