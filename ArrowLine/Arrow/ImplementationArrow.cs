using ArrowLine.CapArrow;
using ArrowLine.Line;
using System.Drawing.Drawing2D;
using ArrowLine.Abstract;
using UMlDrawer.Abstract;

namespace ArrowLine.Arrow
{
    public class ImplementationArrow : AbstractFigure
    {
        public ImplementationArrow(FigureType type)
        {
            Type = type;
        }

        public override void Draw()
        {
            SetDelta();

            AbstractCapArrow arrowCap = new CloseCapArrow(StartPoint, EndPoint);
            arrowCap.Draw();

            AbstractLine line = new DashLine(StartPoint, EndPoint);
            line.Draw();
            pen.DashStyle = DashStyle.Solid;
        }
    }
}
