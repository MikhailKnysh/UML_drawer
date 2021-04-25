using ArrowLine.Abstract;
using System;
using System.Drawing;

namespace ArrowLine.Table
{
    public class ClassTable : AbstractTable
    {
        public ClassTable(FigureType type)
        {
            Type = type;
        }

        public override void Draw()
        {
            format.Alignment = StringAlignment.Center;

            CreateBaseRactangle();
            IncreaseFrame();

            DrawStringRectangle(font, format, title, heightStringRectangle, stepDownPoint: 10);

            titleRectangle = stringRectangle;

            DrawHorizontalLine(lineIndex: 0, stepDownLine - 2);

            GraphicsPictureBox.Graphics.DrawRectangle(pen, objectRectangle);

            DrawNodes();

            format.Alignment = StringAlignment.Near;
        }
    }
}
