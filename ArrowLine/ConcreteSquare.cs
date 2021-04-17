using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowLine
{
    public class ConcreteSquare : AbstractRectangle
    {
        public ConcreteSquare(Pen pen, Graphics graphics)
            : base(pen, graphics)
        {

        }

        public override void Draw( Pen pen, Graphics graphics)
        {
            objectRectangle = new Rectangle(
                Math.Min(_startPoint.X, _endPoint.X),
                Math.Min(_startPoint.Y, _endPoint.Y),
                Math.Abs(_startPoint.X - _endPoint.X),
                Math.Abs(_startPoint.Y - _endPoint.Y));
            graphics.FillRectangle(fillBrush, objectRectangle);
            graphics.DrawRectangle(pen, objectRectangle);
        }
        public override Rectangle ObjectRectangle
        {
            get { return objectRectangle; }
            set { objectRectangle = value;
                objectRegion = new Region(objectRectangle);
            }
        }
    }
}
