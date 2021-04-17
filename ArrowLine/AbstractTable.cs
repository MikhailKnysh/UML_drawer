using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ArrowLine
{
    public abstract class AbstractTable// : AbstractFigure
    {
        protected TextBox title;
        public Point startPoint;
        protected int width = 140;
        protected int height = 60;
        protected int heightStringRectangle = 20;
        protected int stepDownLine = 20;
        protected int stepDownFieldPoint = 20;
        protected int stepDownPropertyPoint = 22;
        protected int stepDownMethodPoint = 24;
        protected List<string> fields;
        protected List<string> properties;
        protected List<string> methods;
        protected List<Rectangle> fieldRectangles;
        protected List<Rectangle> propertieRectangles;
        protected List<Rectangle> methodRectangles;
        protected List<LineInTable> linesInTable;
        public Rectangle objectRectangle;
        protected Rectangle stringRectangle;
        public List<Rectangle> rectangles = new List<Rectangle>();
        public Font font;
        public StringFormat format;
        public Pen whitePen;
        public SolidBrush solidBrush;

        public AbstractTable()
        {
            font = new Font("Arial", 12);
            format = new StringFormat();
            whitePen = new Pen(Color.White, 2);////////////////
            solidBrush = new SolidBrush(Color.Black);//////Pen.Color
            linesInTable = new List<LineInTable>();
            fields = new List<string>();
            fieldRectangles = new List<Rectangle>();
            properties = new List<string>();
            propertieRectangles = new List<Rectangle>();
            methods = new List<string>();
            methodRectangles = new List<Rectangle>();

            format.Alignment = StringAlignment.Center;

            LineInTable lineInTable = new LineInTable();

            for (int i = 0; i < 3; i++)
            {
                linesInTable.Add(lineInTable);
            }
        }

        public virtual void AddField(Pen pen, Graphics graphics)
        {
            stepDownPropertyPoint += 20;
            stepDownMethodPoint += 20;
            format.Alignment = StringAlignment.Near;

            graphics.DrawRectangle(whitePen, objectRectangle);

            if (methodRectangles.Count != 0)
            {
                ClearArea(pen, graphics, methodRectangles);
                ReDrawArea(pen, graphics, methodRectangles, methods);
            }

            if (propertieRectangles.Count != 0)
            {
                ClearArea(pen, graphics, propertieRectangles);
                ReDrawArea(pen, graphics, propertieRectangles, properties);

                DrawHorizontalLine(pen, graphics, lineIndex: 2, stepDownPropertyPoint);
            }

            DrawStringRectangle(graphics, pen, font, format, "Field", heightStringRectangle,
                stepDownPoint: stepDownFieldPoint += 20);

            fields.Add("Field");
            fieldRectangles.Add(stringRectangle);

            objectRectangle.Height += heightStringRectangle;
            graphics.DrawRectangle(pen, objectRectangle);

            DrawHorizontalLine(pen, graphics, lineIndex: 1, stepDownFieldPoint);
        }

        public virtual void AddProperty(Pen pen, Graphics graphics)
        {
            format.Alignment = StringAlignment.Near;

            graphics.DrawRectangle(whitePen, objectRectangle);

            if (methodRectangles.Count != 0)
            {
                ClearArea(pen, graphics, methodRectangles);
                ReDrawArea(pen, graphics, methodRectangles, methods);
            }

            DrawStringRectangle(graphics, pen, font, format, "Property", heightStringRectangle,
                stepDownPoint: stepDownPropertyPoint += 20);

            properties.Add("Property");
            propertieRectangles.Add(stringRectangle);

            objectRectangle.Height += heightStringRectangle;
            graphics.DrawRectangle(pen, objectRectangle);

            //linesInTable[2]._startLinePoint.X = startPoint.X;
            //linesInTable[2]._startLinePoint.Y = startPoint.Y + stepDownPropertyPoint + heightStringRectangle;
            //linesInTable[2]._endLinePoint.X = startPoint.X + width;
            //linesInTable[2]._endLinePoint.Y = startPoint.Y + stepDownPropertyPoint + heightStringRectangle;
            //graphics.DrawLine(pen, linesInTable[2]._startLinePoint, linesInTable[2]._endLinePoint);
            DrawHorizontalLine(pen, graphics, lineIndex: 2, stepDownPropertyPoint);

            stepDownMethodPoint += 20;
        }

        public virtual void AddMethod(Pen pen, Graphics graphics)
        {
            format.Alignment = StringAlignment.Near;

            graphics.DrawRectangle(whitePen, objectRectangle);

            DrawStringRectangle(graphics, pen, font, format, "Method", heightStringRectangle,
                stepDownPoint: stepDownMethodPoint += 20);

            methods.Add("Method");
            methodRectangles.Add(stringRectangle);

            objectRectangle.Height += heightStringRectangle;
            graphics.DrawRectangle(pen, objectRectangle);
        }

        public virtual void Draw(Pen pen, Graphics graphics)
        {
        }
        protected abstract void Resize();
        protected abstract void Move();
        protected virtual void DrawStringRectangle(
            Graphics graphics, Pen pen, Font font, StringFormat format, string text, int heightStringRectangle, int stepDownPoint)
        {
            stringRectangle = new Rectangle(startPoint.X, startPoint.Y + stepDownPoint, width, heightStringRectangle);

            graphics.DrawRectangle(whitePen, startPoint.X, startPoint.Y + stepDownPoint, width, heightStringRectangle);
            graphics.DrawString(text, font, solidBrush, stringRectangle, format);
        }

        protected virtual void ReDrawArea(
            Pen pen, Graphics graphics, List<Rectangle> stringRectangles, List<string> stringData)
        {
            for (int i = 0; i < stringRectangles.Count; i++)
            {
                stringRectangle = new Rectangle(stringRectangles[i].X,
                    stringRectangles[i].Y + 20, width, heightStringRectangle);

                stringRectangles[i] = stringRectangle;

                graphics.DrawRectangle(whitePen, stringRectangles[i].X, stringRectangles[i].Y, width, heightStringRectangle);
                graphics.DrawString(stringData[i], font, solidBrush, stringRectangles[i], format);
            }
        }

        protected virtual void ClearArea(Pen pen, Graphics graphics, List<Rectangle> stringRectangles)
        {
            Point[] points = new Point[] {
                new Point(stringRectangles[0].X,
                    stringRectangles[0].Y),

                new Point(stringRectangles[0].X + width,
                    stringRectangles[0].Y),

                new Point(stringRectangles[stringRectangles.Count - 1].X + width,
                    stringRectangles[stringRectangles.Count - 1].Y),

                new Point(stringRectangles[stringRectangles.Count - 1].X,
                    stringRectangles[stringRectangles.Count - 1].Y),
            };

            SolidBrush shadowBrush = new SolidBrush(Color.White);

            graphics.DrawPolygon(whitePen, points);
            graphics.FillPolygon(shadowBrush, points);
        }

        protected virtual void DrawHorizontalLine(Pen pen, Graphics graphics, int lineIndex, int stepDownPoint)
        {
            linesInTable[lineIndex]._startLinePoint.X = startPoint.X;
            linesInTable[lineIndex]._startLinePoint.Y = startPoint.Y + stepDownPoint + heightStringRectangle;
            linesInTable[lineIndex]._endLinePoint.X = startPoint.X + width;
            linesInTable[lineIndex]._endLinePoint.Y = startPoint.Y + stepDownPoint + heightStringRectangle;
            graphics.DrawLine(pen, linesInTable[lineIndex]._startLinePoint, linesInTable[lineIndex]._endLinePoint);
        }
    }
}
