using ArrowLine.CapArrow;
using ArrowLine.Line;
using System.Drawing;
using System.Drawing.Drawing2D;
using System;

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
            Pen pen = new Pen(singltone.Color, singltone.PenWidth);
            Delta();

            AbstractArrowCap arrowCap = new CloseCapArrow(startPoint, endPoint);
            arrowCap.Draw();

            AbstractLine line = new DashLineArrow(startPoint, endPoint);
            line.Draw();
            pen.DashStyle = DashStyle.Solid;
        }
    }
}
