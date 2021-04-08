using System.Drawing;

namespace ArrowLine
{
    public abstract class AbstractArrow
    { 
        protected const int _arrowSize = 10;
        public Pen _pen;
        public Point _startPoint;
        public Point _endPoint;
        public Graphics graphics;

        public abstract Point[] CreateArrowObject();
        public abstract void Draw(Graphics graphics);
    }
}
