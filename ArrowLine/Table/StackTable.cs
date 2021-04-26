using ArrowLine.Abstract;
using System.Drawing;
using UMlDrawer.Abstract;

namespace ArrowLine.Table
{
    public class StackTable : AbstractTable
    {
        public StackTable(FigureType type)
        {
            Type = type;
        }

        public override void Draw()
        {
            format.Alignment = StringAlignment.Center;

            DrawBackRectangles();

            GraphicsPictureBox.Graphics.FillRectangle(new SolidBrush(Color.White), objectRectangle);
            CreateBaseRactangle();

            IncreaseFrame();

            DrawStringRectangle(font, format, title, heightStringRectangle, stepDownPoint: 10);

            titleRectangle = stringRectangle;

            DrawHorizontalLine(lineIndex: 0, stepDownLine - 2);

            GraphicsPictureBox.Graphics.DrawRectangle(pen, objectRectangle);

            DrawNodes();

            format.Alignment = StringAlignment.Near;
        }

        private void DrawBackRectangles()
        {
            Rectangle backRectangle;

            for (int i = 20; i >= 10; i -= 10)
            {
                backRectangle = new Rectangle(StartPoint.X - i, StartPoint.Y - i, width, height);

                GraphicsPictureBox.Graphics.FillRectangle(new SolidBrush(Color.White), backRectangle);
                GraphicsPictureBox.Graphics.DrawRectangle(pen, backRectangle);
            }
        }
    }
}
