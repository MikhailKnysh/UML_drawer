using System.Drawing;

namespace ArrowLine
{
    public abstract class AbstractArrowCap : AbstractTools
    {
        protected const int _arrowSize = 10;
        protected Point[] _CustomCapArrow;

        protected abstract void CreateArrowCap();
        public abstract void DrawCap();
    }
}
