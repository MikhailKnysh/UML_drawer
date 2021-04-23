using System;
using System.Drawing;

namespace ArrowLine.Table
{
    public class InterfaceTable : AbstractTable
    {
        public InterfaceTable(FigureType type)
        {
            Type = type;
        }


        public override void Draw()
        {
            CreateBaseRactangle();
            DrawStringRectangle(font, format, "<< Interface >>", heightStringRectangle, stepDownPoint: 0);
            DrawStringRectangle(font, format, "Title", heightStringRectangle, stepDownPoint: 20);
            DrawHorizontalLine(lineIndex: 0, stepDownLine - 2);

            foreach (var item in RectanglesPoint(this))
            {
                singltone.Graphics.FillRectangle(Brushes.Red, item);
            }
            singltone.Graphics.DrawRectangle(singltone.pen, objectRectangle);
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
