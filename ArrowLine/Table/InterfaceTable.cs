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

            // Create font and brush.
            Font drawFont = new Font("Arial", 14);
            SolidBrush drawBrush = new SolidBrush(pen.Color);

            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Center;

            linesInTable = new List<LineInTable>();
            LineInTable lineInTable = new LineInTable();

            lineInTable._startLinePoint.X = _startPoint.X;
            lineInTable._startLinePoint.Y = _startPoint.Y + stepDown * 2;
            lineInTable._endLinePoint.X = _startPoint.X + widght;
            lineInTable._endLinePoint.Y = _startPoint.Y + stepDown * 2;

            for (int i = 0; i < 3; i++)
            {
                linesInTable.Add(lineInTable);
            }

            // Create rectangle for drawing.
            int heightRec = stepDown;
            Pen penRec = new Pen(Color.White, pen.Width);

            Rectangle drawRect = new Rectangle(_startPoint.X, _startPoint.Y, widght, heightRec);

            graphics.DrawRectangle(penRec, _startPoint.X, _startPoint.Y, widght, heightRec);
            graphics.DrawString("<< Interface >> ", drawFont, new SolidBrush(pen.Color), drawRect, drawFormat);

            drawRect = new Rectangle(_startPoint.X, _startPoint.Y + stepDown, widght, heightRec);
            graphics.DrawRectangle(penRec, _startPoint.X, _startPoint.Y + stepDown, widght, heightRec);
            graphics.DrawString("Title", drawFont, new SolidBrush(pen.Color), drawRect, drawFormat);




            graphics.DrawLine(pen, lineInTable._startLinePoint, lineInTable._endLinePoint);
            objectRectangle = new Rectangle(_startPoint.X, _startPoint.Y, widght, height);
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
