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
            this.startPoint = startPoint;
        }

        //protected override void AddField()
        //{
        //    throw new NotImplementedException();
        //}

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
            DrawStringRectangle(graphics, pen, font, format, "<< Interface >>", heightStringRectangle, stepDownPoint: 0);
            DrawStringRectangle(graphics, pen, font, format, "Title", heightStringRectangle, stepDownPoint: 20);

            linesInTable[0]._startLinePoint.X = startPoint.X;
            linesInTable[0]._startLinePoint.Y = startPoint.Y + stepDownLine * 2 - 2;
            linesInTable[0]._endLinePoint.X = startPoint.X + widght;
            linesInTable[0]._endLinePoint.Y = startPoint.Y + stepDownLine * 2 - 2;

            graphics.DrawLine(pen, linesInTable[0]._startLinePoint, linesInTable[0]._endLinePoint);

            objectRectangle = new Rectangle(startPoint.X, startPoint.Y, widght, height);
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
