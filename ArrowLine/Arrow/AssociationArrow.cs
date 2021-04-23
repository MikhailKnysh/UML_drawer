using ArrowLine.CapArrow;
using ArrowLine.Line;

namespace ArrowLine.Arrow
{
     public class AssociationArrow : AbstractFigure
    {
        AbstractLine line;
        AbstractArrowCap arrowCap;
        int _arrowSize = 10;

        public AssociationArrow(FigureType type)
        {
            line = new SolidLineArrow(startPoint, endPoint);
            arrowCap = new OpenCapArrow(startPoint, endPoint);
            Type = type;
        }
        //public  Point[] CreateArrowLine()
        //{
        //    return new Point[] {
        //        startPoint,
        //        new Point(startPoint.X, endPoint.Y),
        //        endPoint
        //    };
        //}
        //public Point[] CreateArrowObject()
        //{
        //    Point[] _CustomCapArrow = new Point[]
        //      {
        //        new Point(endPoint.X, endPoint.Y),
        //        endPoint,
        //        new Point(endPoint.X, endPoint.Y)
        //      };

        //    if (startPoint.X < endPoint.X)
        //    {
        //        _CustomCapArrow[0].Y -= _arrowSize;
        //        _CustomCapArrow[0].X -= _arrowSize;

        //        _CustomCapArrow[2].Y += _arrowSize;
        //        _CustomCapArrow[2].X -= _arrowSize;
        //    }
        //    else if (startPoint.Y > endPoint.Y && startPoint.X == endPoint.X)
        //    {
        //        _CustomCapArrow[0].Y += _arrowSize;
        //        _CustomCapArrow[0].X -= _arrowSize;

        //        _CustomCapArrow[2].Y += _arrowSize;
        //        _CustomCapArrow[2].X += _arrowSize;
        //    }
        //    else if (startPoint.X > endPoint.X)
        //    {
        //        _CustomCapArrow[0].Y -= _arrowSize;
        //        _CustomCapArrow[0].X += _arrowSize;

        //        _CustomCapArrow[2].Y += _arrowSize;
        //        _CustomCapArrow[2].X += _arrowSize;
        //    }
        //    else
        //    {
        //        _CustomCapArrow[0].Y -= _arrowSize;
        //        _CustomCapArrow[0].X += _arrowSize;

        //        _CustomCapArrow[2].Y -= _arrowSize;
        //        _CustomCapArrow[2].X -= _arrowSize;
        //    }

        //    return _CustomCapArrow;
        //}

        public override void Draw()
        {
            line.startPoint = startPoint;
            line.endPoint = endPoint;
            arrowCap.startPoint = startPoint;
            arrowCap.endPoint = endPoint;
            Delta();

            singltone.Graphics.DrawLines(singltone.pen, line.CreateArrowLine());
            singltone.Graphics.DrawLines(singltone.pen, arrowCap.CreateArrowObject());
        }
    }
}
