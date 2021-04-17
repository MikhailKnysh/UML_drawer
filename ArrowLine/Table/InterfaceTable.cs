using System;
using System.Drawing;

namespace ArrowLine.Table
{
    public class InterfaceTable : AbstractTable
    {
        public InterfaceTable()
        {
        }

        public InterfaceTable(Point startPoint)
        {
            _startPoint = startPoint;
        }
        public InterfaceTable(Point startPoint, Point endPoint)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
        }

        public override Rectangle ObjectRectangle
        {
            get { return objectRectangle; }
            set
            { objectRectangle = value;
                objectRegion = new Region(objectRectangle);
            }
        }


        //public override void AddProperty()
        //{
        //    throw new NotImplementedException();
        //}

        //protected override void AddMethod()
        //{
        //    throw new NotImplementedException();
        //}

        public override void Draw(Pen pen, Graphics graphics)
        {
            DrawStringRectangle(graphics, font, format, "<< Interface >>", heightStringRectangle, stepDownPoint: 0);
            DrawStringRectangle(graphics, font, format, "Title", heightStringRectangle, stepDownPoint: 20);
            DrawHorizontalLine(pen, graphics, lineIndex: 0, stepDownLine - 2);

            objectRectangle = new Rectangle(startPoint.X, startPoint.Y, width, height);
            graphics.DrawRectangle(pen, objectRectangle);
        }

        protected override void Move()
        {
            throw new NotImplementedException();
        }

        protected override void Resize()
        {
            throw new NotImplementedException();
        }
    }
}
