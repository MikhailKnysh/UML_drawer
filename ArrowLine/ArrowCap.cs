using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowLine
{
    class ArrowCap
    {
        const int arrowSize = 10;
        Graphics _graphics;
        Pen _pen;
        Point startPoint = new Point();
        Point endPoint = new Point();
        Point[] CustomCapArrow;

        public ArrowCap(Graphics _graphics, Pen _pen, Point startPoint, Point endPoint)
        {
            this._graphics = _graphics;
            this._pen = _pen;
            this.startPoint = startPoint;
            this.endPoint = endPoint;
        }

        public void CreateCustomCapArrow()
        {
            CustomCapArrow = new Point[]
            {
                    endPoint,
                    new Point(endPoint.X, endPoint.Y),
                    new Point(endPoint.X, endPoint.Y),
                    new Point(endPoint.X, endPoint.Y),
                    endPoint,
            };

            if (startPoint.X < endPoint.X)
            {
                CustomCapArrow[1].Y -= arrowSize;
                CustomCapArrow[2].X += arrowSize;
                CustomCapArrow[3].Y += arrowSize;
            }
            else if (startPoint.Y > endPoint.Y && startPoint.X == endPoint.X)
            {
                CustomCapArrow[1].X -= arrowSize;
                CustomCapArrow[2].Y -= arrowSize;
                CustomCapArrow[3].X += arrowSize;
            }
            else if (startPoint.X > endPoint.X)
            {
                CustomCapArrow[1].Y -= arrowSize;
                CustomCapArrow[2].X -= arrowSize;
                CustomCapArrow[3].Y += arrowSize;
            }
            else
            {
                CustomCapArrow[1].X -= arrowSize;
                CustomCapArrow[2].Y += arrowSize;
                CustomCapArrow[3].X += arrowSize;
            }

            _graphics.DrawLines(_pen, CustomCapArrow);
        }

        public void CreateCustomCapRhombEnd(bool colorRhomb)
        {
            CustomCapArrow = new Point[]
             {
                    endPoint,
                    new Point(endPoint.X, endPoint.Y),
                    new Point(endPoint.X, endPoint.Y),
                    new Point(endPoint.X, endPoint.Y),
                    endPoint,
             };

            if (startPoint.X < endPoint.X)
            {
                CustomCapArrow[1].X -= arrowSize;
                CustomCapArrow[1].Y -= arrowSize;

                CustomCapArrow[2].X -= 2 * arrowSize;

                CustomCapArrow[3].X -= arrowSize;
                CustomCapArrow[3].Y += arrowSize;
            }
            else if (startPoint.Y > endPoint.Y && startPoint.X == endPoint.X)
            {
                CustomCapArrow[1].X += arrowSize;
                CustomCapArrow[1].Y += arrowSize;

                CustomCapArrow[2].Y += 2 * arrowSize;

                CustomCapArrow[3].X -= arrowSize;
                CustomCapArrow[3].Y += arrowSize;
            }
            else if (startPoint.X > endPoint.X)
            {
                CustomCapArrow[1].X += arrowSize;
                CustomCapArrow[1].Y -= arrowSize;

                CustomCapArrow[2].X += 2 * arrowSize;

                CustomCapArrow[3].X += arrowSize;
                CustomCapArrow[3].Y += arrowSize;
            }
            else
            {
                CustomCapArrow[1].X -= arrowSize;
                CustomCapArrow[1].Y -= arrowSize;

                CustomCapArrow[2].Y -= 2 * arrowSize;

                CustomCapArrow[3].X += arrowSize;
                CustomCapArrow[3].Y -= arrowSize;
            }

            _graphics.DrawPolygon(_pen, CustomCapArrow);
            ChooseColor(colorRhomb);
        }

        public void CreateCustomCapRhombStart(bool colorRhomb)
        {
            CustomCapArrow = new Point[]
            {
                    new Point(startPoint.X, startPoint.Y),
                    new Point(startPoint.X, startPoint.Y),
                    startPoint,
                    new Point(startPoint.X, startPoint.Y),
                    startPoint,
            };

            if (startPoint.X < endPoint.X && startPoint.Y == endPoint.Y)
            {

                CustomCapArrow[1].X += arrowSize;
                CustomCapArrow[1].Y -= arrowSize;

                CustomCapArrow[2].X += 2 * arrowSize;

                CustomCapArrow[3].X += arrowSize;
                CustomCapArrow[3].Y += arrowSize;
            }
            else if (startPoint.Y > endPoint.Y && startPoint.X == endPoint.X)
            {
                CustomCapArrow[1].X -= arrowSize;
                CustomCapArrow[1].Y -= arrowSize;

                CustomCapArrow[2].Y -= 2 * arrowSize;

                CustomCapArrow[3].X += arrowSize;
                CustomCapArrow[3].Y -= arrowSize;
            }
            else if (startPoint.X > endPoint.X && startPoint.Y == endPoint.Y)
            {
                CustomCapArrow[1].X -= arrowSize;
                CustomCapArrow[1].Y -= arrowSize;

                CustomCapArrow[2].X -= 2 * arrowSize;

                CustomCapArrow[3].X -= arrowSize;
                CustomCapArrow[3].Y += arrowSize;
            }
            else
            {
                CustomCapArrow[1].X += arrowSize;
                CustomCapArrow[1].Y += arrowSize;

                CustomCapArrow[2].Y += 2 * arrowSize;

                CustomCapArrow[3].X -= arrowSize;
                CustomCapArrow[3].Y += arrowSize;
            }

            _graphics.DrawPolygon(_pen, CustomCapArrow);
            ChooseColor(colorRhomb);
        }

        public void CreateCustomOpenCapArrow()
        {
            CustomCapArrow = new Point[]
             {
                    new Point(endPoint.X, endPoint.Y),
                    endPoint,
                    new Point(endPoint.X, endPoint.Y)
             };

            if (startPoint.X < endPoint.X)
            {
                CustomCapArrow[0].Y -= arrowSize;
                CustomCapArrow[0].X -= arrowSize;

                CustomCapArrow[2].Y += arrowSize;
                CustomCapArrow[2].X -= arrowSize;
            }
            else if (startPoint.Y > endPoint.Y && startPoint.X == endPoint.X)
            {
                CustomCapArrow[0].Y += arrowSize;
                CustomCapArrow[0].X -= arrowSize;

                CustomCapArrow[2].Y += arrowSize;
                CustomCapArrow[2].X += arrowSize;
            }
            else if (startPoint.X > endPoint.X)
            {
                CustomCapArrow[0].Y -= arrowSize;
                CustomCapArrow[0].X += arrowSize;

                CustomCapArrow[2].Y += arrowSize;
                CustomCapArrow[2].X += arrowSize;
            }
            else
            {
                CustomCapArrow[0].Y -= arrowSize;
                CustomCapArrow[0].X += arrowSize;

                CustomCapArrow[2].Y -= arrowSize;
                CustomCapArrow[2].X -= arrowSize;
            }

            _graphics.DrawLines(_pen, CustomCapArrow);
        }
        
        private void ChooseColor(bool colorRhomb)
        {
            SolidBrush shadowBrush;

            if (colorRhomb)
            {
                shadowBrush = new SolidBrush(Color.White);
            }
            else
            {
                shadowBrush = new SolidBrush(Color.Black);
            }
            _graphics.FillPolygon(shadowBrush, CustomCapArrow);
        }
    }
}