using ArrowLine.Table;
using System.Collections.Generic;
using System.Drawing;

namespace ArrowLine.Abstract
{
    public abstract class AbstractTable : AbstractFigure
    {
        public Rectangle objectRectangle;
        public Font font;
        public StringFormat format;
        public SolidBrush solidBrush;
        public SolidBrush solidBrushWhite;
        public int width = 140;
        public int height = 60;
        public string stringDataTable;
        public string title = "Title";
        protected Rectangle titleRectangle;
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
        protected Rectangle stringRectangle;
        protected Pen whitePen;
        protected Pen blackPen;
        protected Pen DottedLinePen;
        public AbstractTable()
        {
            DottedLinePen = new Pen(Color.Gray, 2);
            DottedLinePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            font = new Font("Arial", 12, FontStyle.Regular);
            format = new StringFormat();
            whitePen = new Pen(Color.White, pen.Width);
            solidBrush = new SolidBrush(Color.Black);
            blackPen = new Pen(pen.Color, pen.Width);
            solidBrushWhite = new SolidBrush(Color.White);
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

        public List<Rectangle> GetRectanglesNodePoints(AbstractFigure objectRectangle)
        {
            var objectRec = objectRectangle as AbstractTable;

            return new List<Rectangle>()
            {


                new Rectangle(objectRec.StartPoint.X + objectRec.width/2 - 15, objectRec.StartPoint.Y - 20, 20, 20),
                new Rectangle(objectRec.StartPoint.X - 20, objectRec.StartPoint.Y + objectRec.height/2 - 12, 20, 20),
                new Rectangle(objectRec.StartPoint.X + objectRec.width/2 - 15, objectRec.StartPoint.Y + objectRec.height , 20, 20 ),
                new Rectangle(objectRec.StartPoint.X + objectRec.width , objectRec.StartPoint.Y + objectRec.height/2 - 10, 20, 20)

            };
        }

        public bool Contains(Point point)
        {
            foreach (var item in GetRectanglesNodePoints(this))
            {
                if (item.Contains(point))
                {
                    return true;
                }
            }
            return false;
        }

        public void CreateBaseRactangle()
        {
            objectRectangle = new Rectangle(StartPoint.X, StartPoint.Y, width, height);
        }

        public void AddField()
        {
            ClearNodes();

            stepDownPropertyPoint += 20;
            stepDownMethodPoint += 20;
            format.Alignment = StringAlignment.Near;

            GraphicsPictureBox.Graphics.DrawRectangle(whitePen, objectRectangle);

            IncreaseFrame();

            if (methodRectangles.Count != 0)
            {
                ReDrawArea(methodRectangles, methods);
            }

            if (propertieRectangles.Count != 0)
            {
                ReDrawArea(propertieRectangles, properties);
                DrawHorizontalLine(lineIndex: 2, stepDownPropertyPoint + 1);
            }

            fields.Add(stringDataTable);
            fieldRectangles.Add(stringRectangle);

            DrawStringRectangle(font, format, stringDataTable, heightStringRectangle,
                stepDownPoint: stepDownFieldPoint += 20);


            height += heightStringRectangle;
            objectRectangle.Height += heightStringRectangle;

            DrawNodes();

            DrawHorizontalLine(lineIndex: 1, stepDownFieldPoint + 1);
        }

        public  void AddProperty()
        {
            ClearNodes();

            stepDownMethodPoint += 20;

            format.Alignment = StringAlignment.Near;

            GraphicsPictureBox.Graphics.DrawRectangle(whitePen, objectRectangle);

            IncreaseFrame();

            if (methodRectangles.Count != 0)
            {
                ReDrawArea(methodRectangles, methods);
            }

            DrawStringRectangle(font, format, stringDataTable, heightStringRectangle,
                stepDownPoint: stepDownPropertyPoint += 20);

            properties.Add(stringDataTable);
            propertieRectangles.Add(stringRectangle);

            height += heightStringRectangle;
            objectRectangle.Height += heightStringRectangle;

            DrawNodes();

            GraphicsPictureBox.Graphics.DrawRectangle(pen, objectRectangle);

            DrawHorizontalLine(lineIndex: 2, stepDownPropertyPoint + 1);
        }

        public void AddMethod()
        {
            ClearNodes();

            format.Alignment = StringAlignment.Near;

            GraphicsPictureBox.Graphics.DrawRectangle(whitePen, objectRectangle);

            IncreaseFrame();

            DrawStringRectangle(font, format, stringDataTable, heightStringRectangle,
                stepDownPoint: stepDownMethodPoint += 20);

            methods.Add(stringDataTable);
            methodRectangles.Add(stringRectangle);

            height += heightStringRectangle;
         
            objectRectangle.Height += heightStringRectangle;

            DrawNodes();

            GraphicsPictureBox.Graphics.DrawRectangle(pen, objectRectangle);

        }

        protected virtual void DrawStringRectangle(
            Font font, StringFormat format, string text, int heightStringRectangle, int stepDownPoint)
        {
            stringRectangle = new Rectangle(StartPoint.X, StartPoint.Y + stepDownPoint, width, heightStringRectangle);
            GraphicsPictureBox.Graphics.FillRectangle(solidBrushWhite, stringRectangle);
            GraphicsPictureBox.Graphics.DrawString(text, font, solidBrush, stringRectangle, format);
        }

        protected virtual void ReDrawArea(List<Rectangle> stringRectangles, List<string> stringData)
        {
            for (int i = 0; i < stringRectangles.Count; i++)
            {
                stringRectangle = new Rectangle(stringRectangles[i].X,
                 stringRectangles[i].Y + 20, width, heightStringRectangle);

                stringRectangles[i] = stringRectangle;
                GraphicsPictureBox.Graphics.FillRectangle(solidBrushWhite, stringRectangles[i].X, stringRectangles[i].Y, width, heightStringRectangle);
                GraphicsPictureBox.Graphics.DrawString(stringData[i], font, solidBrush, stringRectangles[i], format);
            }
        }

        public  void ReDrawRectangleBody()
        {
            int tmpStepDownPoint = 40;

            for (int i = 0; i < fieldRectangles.Count; i++)
            {
                stringRectangle = new Rectangle(StartPoint.X,
                    StartPoint.Y + tmpStepDownPoint, width, heightStringRectangle);
                fieldRectangles[i] = stringRectangle;
                tmpStepDownPoint += 20;

                GraphicsPictureBox.Graphics.FillRectangle(solidBrushWhite, fieldRectangles[i].X, fieldRectangles[i].Y, width, heightStringRectangle);
                GraphicsPictureBox.Graphics.DrawString(fields[i], font, solidBrush, fieldRectangles[i], format);
            }

            DrawHorizontalLine(lineIndex: 1, stepDownFieldPoint);

            for (int i = 0; i < propertieRectangles.Count; i++)
            {
                stringRectangle = new Rectangle(StartPoint.X,
                    StartPoint.Y + tmpStepDownPoint + 2, width, heightStringRectangle);
                propertieRectangles[i] = stringRectangle;
                tmpStepDownPoint += 20;
                GraphicsPictureBox.Graphics.FillRectangle(solidBrushWhite, propertieRectangles[i].X, propertieRectangles[i].Y, width, heightStringRectangle);
                GraphicsPictureBox.Graphics.DrawString(properties[i], font, solidBrush, propertieRectangles[i], format);
            }

            DrawHorizontalLine(lineIndex: 2, stepDownPropertyPoint);

            for (int i = 0; i < methodRectangles.Count; i++)
            {
                stringRectangle = new Rectangle(StartPoint.X,
                    StartPoint.Y + tmpStepDownPoint + 4, width, heightStringRectangle);
                methodRectangles[i] = stringRectangle;
                tmpStepDownPoint += 20;
                GraphicsPictureBox.Graphics.FillRectangle(solidBrushWhite, methodRectangles[i].X, methodRectangles[i].Y, width, heightStringRectangle);
                GraphicsPictureBox.Graphics.DrawString(methods[i], font, solidBrush, methodRectangles[i], format);
            }
        }

        protected virtual void DrawHorizontalLine(int lineIndex, int stepDownPoint)
        {
            linesInTable[lineIndex]._startLinePoint.X = StartPoint.X;
            linesInTable[lineIndex]._startLinePoint.Y = StartPoint.Y + stepDownPoint + heightStringRectangle;
            linesInTable[lineIndex]._endLinePoint.X = StartPoint.X + width;
            linesInTable[lineIndex]._endLinePoint.Y = StartPoint.Y + stepDownPoint + heightStringRectangle;
            GraphicsPictureBox.Graphics.DrawLine(pen , linesInTable[lineIndex]._startLinePoint, linesInTable[lineIndex]._endLinePoint);
        }

        protected virtual void IncreaseFrame()
        {
            float stringWidth = GraphicsPictureBox.Graphics.MeasureString(stringDataTable, font).Width;
            float titleWidth = GraphicsPictureBox.Graphics.MeasureString(title, font).Width;

            if (stringWidth > width || titleWidth > width)
            {
                width = (int)stringWidth + 2;
                DrawHorizontalLine(lineIndex: 0, stepDownLine - 2);
                DrawHorizontalLine(lineIndex: 1, stepDownFieldPoint + 1);
                DrawHorizontalLine(lineIndex: 2, stepDownPropertyPoint + 1);
            }

            objectRectangle.Width = width;
        }

        protected virtual void DrawNodes()
        {
            foreach (var item in GetRectanglesNodePoints(this))
            {
                GraphicsPictureBox.Graphics.DrawRectangle(DottedLinePen, item);
            }
            GraphicsPictureBox.Graphics.DrawRectangle(pen, objectRectangle);
        }

        protected virtual void ClearNodes()
        {
            foreach (var item in GetRectanglesNodePoints(this))
            {
                GraphicsPictureBox.Graphics.DrawRectangle(whitePen, item);
            }
        }
    }
}
