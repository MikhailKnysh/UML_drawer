using System.Drawing;

namespace ArrowLine
{
    public abstract class AbstractArrow : AbstractTools
    {
        protected const int _arrowSize = 10;

        //protected Point[] _CustomCapArrow;

        protected abstract Point[] CreateArrowObject();
        public abstract void Draw(Graphics graphics);
    }
}
