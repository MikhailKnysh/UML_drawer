using ArrowLine.Abstract;
using System.Drawing;

namespace ArrowLine.CapArrow
{
    public class BlackRhombStartCapArrow : AbstractArrowCap
    {
        public BlackRhombStartCapArrow()
        {

        }
        public BlackRhombStartCapArrow(Point startPoint, Point endPoint)
        {
            
            this.startPoint = startPoint;
            this.endPoint = endPoint;
        }

        public override Point[] CreateArrowObject()
        {
            Point[] _CustomCapArrow = new Point[]
            {
               new Point(startPoint.X, startPoint.Y -_arrowSize),
                new Point(startPoint.X + _arrowSize, startPoint.Y),
                new Point(startPoint.X , startPoint.Y + _arrowSize),
                new Point(startPoint.X - _arrowSize, startPoint.Y),
                new Point(startPoint.X, startPoint.Y - _arrowSize),
            };


            return _CustomCapArrow;
        }

        public override void Draw()
        {
            SolidBrush shadowBrush = new SolidBrush(pen.Color);

            GraficPictureBox.Graphics.DrawPolygon(pen, CreateArrowObject());
            GraficPictureBox.Graphics.FillPolygon(shadowBrush, CreateArrowObject());
        }
    }
}
