using System.Drawing;

namespace ArrowLine
{
    public abstract class AbstractArrowCap: AbstractFigure
    {
        protected int _arrowSize = 10;

        public abstract Point[] CreateArrowObject();

       // private Point _endPoint;

        //public Point endPoint
        //{
        //    get
        //    {
        //        return _endPoint;
        //    }
        //    set
        //    {
        //        _endPoint = value;
        //    }
        //}


    }
}
