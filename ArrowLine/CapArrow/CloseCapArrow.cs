﻿using UMLDrawer.Abstract;
using System;
using System.Drawing;

namespace UMLDrawer.CapArrow
{
    public class CloseCapArrow : AbstractCapArrow
    {
        public CloseCapArrow(Point startPoint, Point endPoint)
        {
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
        }

        public override Point[] CreateArrowObject()
        {
            Point[] _CustomCapArrow = new Point[]
            {
                EndPoint,
                new Point(EndPoint.X, EndPoint.Y),
                new Point(EndPoint.X, EndPoint.Y),
                new Point(EndPoint.X, EndPoint.Y),
                EndPoint,
            };

            if (StartPoint.X < EndPoint.X && Math.Abs(StartPoint.X - EndPoint.X) > Math.Abs(StartPoint.Y - EndPoint.Y))
            {
                _CustomCapArrow[1].Y -= _arrowSize;
                _CustomCapArrow[2].X += _arrowSize;
                _CustomCapArrow[3].Y += _arrowSize;
            }
            else if (StartPoint.Y > EndPoint.Y && Math.Abs(StartPoint.X - EndPoint.X) < Math.Abs(StartPoint.Y - EndPoint.Y))
            {
                _CustomCapArrow[1].X -= _arrowSize;
                _CustomCapArrow[2].Y -= _arrowSize;
                _CustomCapArrow[3].X += _arrowSize;
            }
            
            if (StartPoint.X > EndPoint.X && Math.Abs(StartPoint.X - EndPoint.X) > Math.Abs(StartPoint.Y - EndPoint.Y))
            {
                _CustomCapArrow[1].Y -= _arrowSize;
                _CustomCapArrow[2].X -= _arrowSize;
                _CustomCapArrow[3].Y += _arrowSize;
            }
            else if(StartPoint.Y < EndPoint.Y && Math.Abs(StartPoint.X - EndPoint.X) < Math.Abs(StartPoint.Y - EndPoint.Y))
            {
                
                _CustomCapArrow[1].X -= _arrowSize;
                _CustomCapArrow[2].Y += _arrowSize;
                _CustomCapArrow[3].X += _arrowSize;
            }

            return _CustomCapArrow;
        }

        public override void Draw()
        {
            GraphicsPictureBox.Graphics.DrawLines(pen, CreateArrowObject());
        }
    }
}
