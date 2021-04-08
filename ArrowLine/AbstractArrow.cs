using System.Drawing;

namespace ArrowLine
{
    public abstract class AbstractArrow
    {
        protected int _arrowSize = 10;
        public Pen _pen;
        public Point _startPoint;
        public Point _endPoint;

        public abstract void Draw(Graphics graphics);
    }
}
