using System.Drawing;

namespace ArrowLine
{
    public abstract class AbstractArrow : AbstractTools
    {
        public Pen _pen;
        public Point _startPoint;
        public Point _endPoint;
        protected const int _arrowSize = 10;
        public Graphics graphics;


        //protected Point[] _CustomCapArrow;

        protected abstract Point[] CreateArrowObject();
        //public abstract void Draw(Graphics graphics);
        public abstract void Draw();
    }
}
