using System.Drawing;

namespace ArrowLine
{
    public abstract class AbstractLine : AbstractFigure
    {

        public virtual Point[] CreateArrowLine()
        {
            int midlle = (startPoint.X + endPoint.X) / 2;

            return new Point[] {
                startPoint,
                new Point(midlle, startPoint.Y),
                new Point(midlle, endPoint.Y),
                endPoint
            };
        }
        //public virtual Point[] CreateArrowLine()
        //{
        //    return new Point[] {
        //        startPoint,
        //        new Point(startPoint.X, endPoint.Y),
        //        endPoint
        //    };
        //}
    }
}
