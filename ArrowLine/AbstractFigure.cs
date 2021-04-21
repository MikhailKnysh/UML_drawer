using System.Drawing;

namespace ArrowLine
{
    //make as interface

    public abstract class AbstractFigure
    {
        public Point _startPoint;
        public Point _endPoint;
        protected int width = 140;
        protected int height = 60;

        public abstract void Draw(Pen pen, Graphics graphics);
    }
}
