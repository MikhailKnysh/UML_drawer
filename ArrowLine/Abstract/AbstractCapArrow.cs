using System.Drawing;

namespace ArrowLine.Abstract
{
    public abstract class AbstractCapArrow: AbstractFigure
    {
        protected int _arrowSize = 10;
        
        public abstract Point[] CreateArrowObject();
    }
}
