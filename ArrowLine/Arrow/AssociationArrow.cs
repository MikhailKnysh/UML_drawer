using ArrowLine.Abstract;
using ArrowLine.CapArrow;
using ArrowLine.Line;

namespace ArrowLine.Arrow
{
     public class AssociationArrow : AbstractFigure
    {
        AbstractLine line;
        AbstractArrowCap arrowCap;
        public AssociationArrow()
        {

        }
        public AssociationArrow(FigureType type)
        {
            line = new SolidLineArrow(startPoint, endPoint);
            arrowCap = new OpenCapArrow(startPoint, endPoint);
            Type = type;
        }
      
        public override void Draw()
        {
            line.startPoint = startPoint;
            line.endPoint = endPoint;
            arrowCap.startPoint = startPoint;
            arrowCap.endPoint = endPoint;
            Delta();

            singltone.Graphics.DrawLines(pen, line.CreateArrowLine());
            singltone.Graphics.DrawLines(pen, arrowCap.CreateArrowObject());
        }
    }
}
