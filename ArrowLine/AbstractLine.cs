using System.Drawing;

namespace ArrowLine
{
    public abstract class AbstractLine : AbstractFigure
    {
        
        public virtual Point[] CreateArrowLine()
        {
            return new Point[] {
                startPoint,
                new Point(startPoint.X, endPoint.Y),
                endPoint
            };
        }
    }
}
