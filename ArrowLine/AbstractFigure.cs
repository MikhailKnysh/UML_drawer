using System.Drawing;

namespace ArrowLine
{
    //make as interface

    public abstract class AbstractFigure
    {
        public Singltone singltone = Singltone.GetInstance();
        public Point _startPoint;
        public Point _endPoint;
        protected Region objectRegion;
        public abstract void Draw();
    }
}
