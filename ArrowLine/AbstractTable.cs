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
        protected int stepDownPoint = 20;
        protected List<string> fields;
        protected List<Rectangle> fieldRectangles;
        protected List<string> properties;
        protected List<Rectangle> propertieRectangles;
        protected List<string> methods;
        protected List<Rectangle> methodRectangles;
        protected List<LineInTable> linesInTable;
        public Rectangle objectRectangle;
        protected Rectangle stringRectangle;
        public List<Rectangle> rectangles = new List<Rectangle>();
        public Font font;
        public StringFormat format;

        public AbstractTable()
        {
            font = new Font("Arial", 12);
            format = new StringFormat();
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
            format.Alignment = StringAlignment.Near;
            Pen whitePen = new Pen(Color.White, pen.Width);

            graphics.DrawRectangle(whitePen, objectRectangle);

            if (propertieRectangles.Count != 0 && fieldRectangles.Count != 0)
            {
                Point[] points = new Point[] {
                    new Point(propertieRectangles[0].X,
                    propertieRectangles[0].Y),

                    new Point(propertieRectangles[0].X + widght ,
                    propertieRectangles[0].Y),

                    new Point(propertieRectangles[propertieRectangles.Count - 1].X + widght ,
                    propertieRectangles[propertieRectangles.Count - 1].Y + heightStringRectangle),

                    new Point(propertieRectangles[propertieRectangles.Count - 1].X ,
                    propertieRectangles[propertieRectangles.Count - 1].Y  + heightStringRectangle),

                };
                SolidBrush shadowBrush = new SolidBrush(Color.White);

                graphics.DrawPolygon(whitePen, points);
                graphics.FillPolygon(shadowBrush, points);


                for (int i = 0; i < propertieRectangles.Count; i++)
                {
                    stringRectangle = new Rectangle(propertieRectangles[i].X, propertieRectangles[i].Y + 20, widght, heightStringRectangle);

                    propertieRectangles[i] = stringRectangle;

                    Pen penRectangle = new Pen(Color.White, pen.Width);
                    graphics.DrawRectangle(penRectangle, propertieRectangles[i].X, propertieRectangles[i].Y, widght, heightStringRectangle);
                    graphics.DrawString(properties[i], font, new SolidBrush(pen.Color), propertieRectangles[i], format);
                  
                }
                /*linesInTable[2]._startLinePoint.X = startPoint.X;
                linesInTable[2]._startLinePoint.Y +=  20;
                linesInTable[2]._endLinePoint.X = startPoint.X + widght;
                linesInTable[2]._endLinePoint.Y += 20;

                graphics.DrawLine(pen, linesInTable[2]._startLinePoint, linesInTable[2]._endLinePoint);
*/
            }

            DrawStringRectangle(graphics, pen, font, format, "Field", heightStringRectangle,
                stepDownPoint: stepDownPoint += 20);

            fields.Add("Field");
            fieldRectangles.Add(stringRectangle);


            objectRectangle.Height += heightStringRectangle;
            graphics.DrawRectangle(pen, objectRectangle);

            linesInTable[1]._startLinePoint.X = startPoint.X;
            linesInTable[1]._startLinePoint.Y = startPoint.Y + stepDownPoint + heightStringRectangle;
            linesInTable[1]._endLinePoint.X = startPoint.X + widght;
            linesInTable[1]._endLinePoint.Y = startPoint.Y + stepDownPoint + heightStringRectangle;

            graphics.DrawLine(pen, linesInTable[1]._startLinePoint, linesInTable[1]._endLinePoint);

        }

        public virtual void AddProperty(Pen pen, Graphics graphics)
        {
            format.Alignment = StringAlignment.Near;
            //font = new Font("Arial", 12);

            Pen whitePen = new Pen(Color.White, pen.Width);

            graphics.DrawRectangle(whitePen, objectRectangle);

            DrawStringRectangle(graphics, pen, font, format, "Property", heightStringRectangle,
                stepDownPoint: objectRectangle.Height - heightStringRectangle);

            properties.Add("Property");
            propertieRectangles.Add(stringRectangle);

            objectRectangle.Height += heightStringRectangle;
            graphics.DrawRectangle(pen, objectRectangle);

            linesInTable[2]._startLinePoint.X = startPoint.X;
            linesInTable[2]._startLinePoint.Y = startPoint.Y + (objectRectangle.Height - heightStringRectangle);
            linesInTable[2]._endLinePoint.X = startPoint.X + widght;
            linesInTable[2]._endLinePoint.Y = startPoint.Y + (objectRectangle.Height - heightStringRectangle);

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
            stringRectangle = new Rectangle(startPoint.X, startPoint.Y + stepDownPoint, widght, heightStringRectangle);
            Pen penRectangle = new Pen(Color.White, pen.Width);

            graphics.DrawRectangle(penRectangle, startPoint.X, startPoint.Y + stepDownPoint, widght, heightStringRectangle);
            graphics.DrawString(text, font, new SolidBrush(pen.Color), stringRectangle, format);
        }

        //protected 
    }
}
