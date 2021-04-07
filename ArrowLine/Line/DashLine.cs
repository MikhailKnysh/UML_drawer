﻿using System.Drawing;
using System.Drawing.Drawing2D;

namespace ArrowLine.Line
{
    public class DashLine : AbstractArrow
    {
        public DashLine(Pen pen)
        {
            _pen = pen;
        }

        public override void Draw(Graphics graphics)
        {
            _pen.DashStyle = DashStyle.Dash;
            graphics.DrawLines(_pen, CreateArrowObject());
        }

        protected override Point[] CreateArrowObject()
        {
            return new Point[] {
                _startPoint,
                new Point(_startPoint.X, _endPoint.Y),
                _endPoint
            };
        }
    }
}
