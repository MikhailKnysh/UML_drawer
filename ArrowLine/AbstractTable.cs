using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ArrowLine
{
    public abstract class AbstractTable// : AbstractFigure
    {
        protected TextBox title;
        public Point startPoint;
        protected int widght = 140;
        protected int height = 60;
        protected int heightStringRectangle = 20;
        protected int stepDownLine = 20;
        protected List<string> fields;
        protected List<string> properties;
        protected List<string> methods;
        protected List<LineInTable> linesInTable;
        public Rectangle objectRectangle;
        public List<Rectangle> rectangles = new List<Rectangle>();
        public Font font;
        public StringFormat format;

        public AbstractTable()
        {
            font = new Font("Arial", 14);
            format = new StringFormat();
            linesInTable = new List<LineInTable>();

            format.Alignment = StringAlignment.Center;

            LineInTable lineInTable = new LineInTable();

            for (int i = 0; i < 3; i++)
            {
                linesInTable.Add(lineInTable);
            }
        }

        public virtual void AddField(Pen pen, Graphics graphics)
        {
            format.Alignment = StringAlignment.Near;
            font = new Font("Arial", 12);

            Pen whitePen = new Pen(Color.White, pen.Width);

            graphics.DrawRectangle(whitePen, objectRectangle);

            DrawStringRectangle(graphics, pen, font, format, "Field", heightStringRectangle-2, stepDownPoint: objectRectangle.Height - heightStringRectangle +2);

            objectRectangle.Height += heightStringRectangle;
            graphics.DrawRectangle(pen, objectRectangle);

            linesInTable[1]._startLinePoint.X = startPoint.X;
            linesInTable[1]._startLinePoint.Y = startPoint.Y + (objectRectangle.Height - heightStringRectangle+2);
            linesInTable[1]._endLinePoint.X = startPoint.X + widght;
            linesInTable[1]._endLinePoint.Y = startPoint.Y + (objectRectangle.Height - heightStringRectangle+2);

            graphics.DrawLine(pen, linesInTable[1]._startLinePoint, linesInTable[1]._endLinePoint);

        }
        public virtual void AddProperty(Pen pen, Graphics graphics) {
            format.Alignment = StringAlignment.Near;
            font = new Font("Arial", 12);

            Pen whitePen = new Pen(Color.White, pen.Width);

            graphics.DrawRectangle(whitePen, objectRectangle);

            DrawStringRectangle(graphics, pen, font, format, "Property", heightStringRectangle - 2, stepDownPoint: objectRectangle.Height - heightStringRectangle + 4);

            objectRectangle.Height += heightStringRectangle;
            graphics.DrawRectangle(pen, objectRectangle);

            linesInTable[2]._startLinePoint.X = startPoint.X;
            linesInTable[2]._startLinePoint.Y = startPoint.Y + (objectRectangle.Height - heightStringRectangle + 4);
            linesInTable[2]._endLinePoint.X = startPoint.X + widght;
            linesInTable[2]._endLinePoint.Y = startPoint.Y + (objectRectangle.Height - heightStringRectangle + 4);

            graphics.DrawLine(pen, linesInTable[2]._startLinePoint, linesInTable[2]._endLinePoint);
        }
        public virtual void AddMethod() { }
        public virtual void Draw(Pen pen, Graphics graphics)
        {
        }
        protected abstract void Resize();
        protected abstract void Move();
        protected virtual void DrawStringRectangle(
            Graphics graphics, Pen pen, Font font, StringFormat format, string text, int heightStringRectangle, int stepDownPoint)
        {
            Rectangle rectangle = new Rectangle(startPoint.X, startPoint.Y + stepDownPoint, widght, heightStringRectangle);
            Pen penRectangle = new Pen(Color.White, pen.Width);

            graphics.DrawRectangle(penRectangle, startPoint.X, startPoint.Y + stepDownPoint, widght, heightStringRectangle);
            graphics.DrawString(text, font, new SolidBrush(pen.Color), rectangle, format);
        }
    }
}
