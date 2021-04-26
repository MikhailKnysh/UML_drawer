using System.Drawing;

namespace UMLDrawer.Abstract
{
    public abstract class AbstractCapArrow: AbstractFigure
    {
        protected int _arrowSize = 10;
        
        public abstract Point[] CreateArrowObject();
    }
}
