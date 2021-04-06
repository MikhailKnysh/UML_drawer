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
        Point startPoint = new Point();
        Point endPoint = new Point();
        Pen _pen;
        Graphics _graphics;

        public Line(Pen _pen, Point startPoint, Point endPoint, Graphics _graphics)
        {
            this._pen = _pen;
            this.startPoint = startPoint;
            this.endPoint = endPoint;
            this._graphics = _graphics;
        }

        public void DrawLine(bool chooseLine)
        {
            Point cointermediate = new Point(startPoint.X, endPoint.Y);
            Point[] points = { startPoint, cointermediate, endPoint };

            if (chooseLine)
            {
                _pen.DashStyle = DashStyle.Dash;
            }

            _graphics.DrawLines(_pen, points);
        }
    }
}
