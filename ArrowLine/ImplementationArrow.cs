using ArrowLine.Arrow;
using ArrowLine.Line;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ArrowLine
{
    public class ImplementationArrow: AbstractArrow
    {
        public override void Draw(Pen pen, Graphics graphics)
        {
            AbstractArrow arrowCap = new CustomCloseCap(_startPoint, _endPoint);
            arrowCap.Draw(pen, graphics);
            AbstractArrow line = new DashLine(_startPoint, _endPoint);
            line.Draw(pen, graphics);
            pen.DashStyle = DashStyle.Solid;
            
        }
    }
}
