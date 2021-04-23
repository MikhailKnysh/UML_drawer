using System;
using System.Drawing;

namespace ArrowLine.Table
{
    public class ClassTable : AbstractTable
    {
        public ClassTable()
        {
        }

        public override void Draw()
        {
            format.Alignment = StringAlignment.Center;

            CreateBaseRactangle();
            IncreaseFrame();

            DrawStringRectangle(font, format, title, heightStringRectangle, stepDownPoint: 10);

            titleRectangle = stringRectangle;

            DrawHorizontalLine(lineIndex: 0, stepDownLine - 2);

            singltone.Graphics.DrawRectangle(singltone.pen, objectRectangle);

            format.Alignment = StringAlignment.Near;
        }

        protected override void Resize()
        {
            throw new NotImplementedException();
        }
    }
}
