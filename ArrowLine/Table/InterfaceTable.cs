using System;
using System.Drawing;

namespace ArrowLine.Table
{
    public class InterfaceTable : AbstractTable
    {
        public InterfaceTable()
        {
        }

        public override void Draw()
        {
            format.Alignment = StringAlignment.Center;

            CreateBaseRactangle();
            DrawStringRectangle(font, format, "<< Interface >>", heightStringRectangle, stepDownPoint: 0);
            DrawStringRectangle(font, format, "Title", heightStringRectangle, stepDownPoint: 20);

            DrawHorizontalLine(lineIndex: 0, stepDownLine - 2);

            singltone.Graphics.DrawRectangle(singltone.pen, objectRectangle);

            format.Alignment = StringAlignment.Near;
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
