using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ArrowLine
{
    public abstract class AbstractTable
    {
        protected TextBox title;
        public Point startPoint;
        protected int widght = 120;
        protected int height = 160;
        protected int stepDown = 24;
        protected List<string> fields;
        protected List<string> properties;
        protected List<string> methods;
        protected List<LineInTable> linesInTable;

        protected abstract void AddField();
        protected abstract void AddMethod();
        public virtual void Draw(Pen pen, Graphics graphics)
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
        protected abstract void Resize();
        protected abstract void Move();
    }
}
