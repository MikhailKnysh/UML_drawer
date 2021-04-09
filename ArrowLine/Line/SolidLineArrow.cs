﻿using System.Drawing;

namespace ArrowLine.Line
{
    public class SolidLineArrow : AbstractArrow, ILine
    {
        public SolidLineArrow(Point startPoint, Point endPoint)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
        }

        public override void Draw(Pen pen,Graphics graphics)
        {
            graphics.DrawLines(pen, CreateArrowLine());
        }

        public Point[] CreateArrowLine()
        {
            return new Point[] {
                _startPoint,
                new Point(_startPoint.X, _endPoint.Y),
                _endPoint
            };
        }
    }
}