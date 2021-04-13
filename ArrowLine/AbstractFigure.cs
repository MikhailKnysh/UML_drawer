using System.Drawing;

namespace ArrowLine
{
    //make as interface

    public abstract class AbstractFigure
    {
        public Point _startPoint;
        public Point _endPoint;

        public abstract void Draw(Pen pen, Graphics graphics);
    }
}
