using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowLine
{
    public class DrawMouseHandler : IMouseHandler 
    {
        public void OnMouseDown()
        {
            crntFigure._startPoint = e.Location;
            crntFigure._endPoint = e.Location;
            table.startPoint = e.Location;
        }

        public void OnMouseMove()
        {
            throw new NotImplementedException();
        }

        public void OnMouseUp()
        {
            throw new NotImplementedException();
        }

        public void OnPaint()
        {
            throw new NotImplementedException();
        }
    }
}
