using System.Drawing;

namespace ArrowLine
{
    public abstract class AbstractArrow
    {
        
        public Point _startPoint;
        public Point _endPoint;

        public abstract void Draw(Pen pen, Graphics graphics);
    }
}
