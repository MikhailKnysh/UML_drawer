using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

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

        protected override void AddField()
        {
            throw new NotImplementedException();
        }

        protected override void AddMethod()
        {
            throw new NotImplementedException();
        }

        public override void Draw(Pen pen, Graphics graphics)
        {
            graphics.DrawRectangle(pen, new Rectangle(startPoint.X, startPoint.Y, widght, height));

            linesInTable = new List<LineInTable>();
            LineInTable lineInTable = new LineInTable();

            lineInTable._startLinePoint.X = startPoint.X;
            lineInTable._startLinePoint.Y = startPoint.Y + stepDown * 2;
            lineInTable._endLinePoint.X = startPoint.X + widght;
            lineInTable._endLinePoint.Y = startPoint.Y + stepDown * 2;

            for (int i = 0; i < 3; i++)
            {
                linesInTable.Add(lineInTable);
            }

            graphics.DrawLine(pen, lineInTable._startLinePoint, lineInTable._endLinePoint);
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
