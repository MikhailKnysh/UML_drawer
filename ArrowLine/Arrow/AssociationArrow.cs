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

            GraficPictureBox.Graphics.DrawLines(pen, line.CreateArrowLine());
            GraficPictureBox.Graphics.DrawLines(pen, arrowCap.CreateArrowObject());
        }
    }
}
