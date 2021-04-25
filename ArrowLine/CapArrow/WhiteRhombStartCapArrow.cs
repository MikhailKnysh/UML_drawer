using ArrowLine.Abstract;
using System.Drawing;

namespace ArrowLine.CapArrow
{
    public class WhiteRhombStartCapArrow : AbstractCapArrow
    {
        public WhiteRhombStartCapArrow(Point startPoint, Point endPoint)
        {
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
        }

        public override Point[] CreateArrowObject()
        {
            Point[] _CustomCapArrow = new Point[]
            {
                new Point(StartPoint.X, StartPoint.Y -_arrowSize),
                new Point(StartPoint.X + _arrowSize, StartPoint.Y),
                new Point(StartPoint.X , StartPoint.Y + _arrowSize),
                new Point(StartPoint.X - _arrowSize, StartPoint.Y),
                new Point(StartPoint.X, StartPoint.Y - _arrowSize),
            };
           
            return _CustomCapArrow;
        }

        public override void Draw()
        {
            SolidBrush shadowBrush = new SolidBrush(Color.White);

            GraphicsPictureBox.Graphics.DrawPolygon(pen, CreateArrowObject());
            GraphicsPictureBox.Graphics.FillPolygon(shadowBrush, CreateArrowObject());
        }
    }
}
