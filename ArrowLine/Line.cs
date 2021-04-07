using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowLine
{
    class Line
    {
        private Point _startPoint = new Point();
        private Point _endPoint = new Point();
        private Pen _pen;
        private Graphics _graphics;

        public Line(Pen pen, Point startPoint, Point endPoint, Graphics graphics)
        {
            _pen = pen;
            _startPoint = startPoint;
            _endPoint = endPoint;
            _graphics = graphics;
        }

        public void DrawLine(bool chooseLine)
        {
            Point cointermediate = new Point(_startPoint.X, _endPoint.Y);
            Point[] points = { _startPoint, cointermediate, _endPoint };

            if (chooseLine)
            {
                _pen.DashStyle = DashStyle.Dash;
            }

            _graphics.DrawLines(_pen, points);
         //   _pen.DashStyle = DashStyle.Solid;
        }
    }
}
