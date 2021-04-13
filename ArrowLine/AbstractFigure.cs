using System.Drawing;

namespace ArrowLine
{
    public abstract class AbstractFigure
    {
        public Point _startPoint;

        public abstract void Draw(Pen pen, Graphics graphics);
    }
}
