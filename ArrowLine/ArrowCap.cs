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
        private const int _arrowSize = 10;
        private Graphics _graphics;
        private Pen _pen;
        private Point _startPoint = new Point();
        private Point _endPoint = new Point();
        private Point[] _CustomCapArrow;

        public ArrowCap(Graphics _graphics, Pen _pen, Point startPoint, Point endPoint)
        {
            this._graphics = _graphics;
            this._pen = _pen;
            this._startPoint = startPoint;
            this._endPoint = endPoint;
        }

        public void CreateCustomCapArrow()
        {
            _CustomCapArrow = new Point[]
            {
                    _endPoint,
                    new Point(_endPoint.X, _endPoint.Y),
                    new Point(_endPoint.X, _endPoint.Y),
                    new Point(_endPoint.X, _endPoint.Y),
                    _endPoint,
            };

            if (_startPoint.X < _endPoint.X)
            {
                _CustomCapArrow[1].Y -= _arrowSize;
                _CustomCapArrow[2].X += _arrowSize;
                _CustomCapArrow[3].Y += _arrowSize;
            }
            else if (_startPoint.Y > _endPoint.Y && _startPoint.X == _endPoint.X)
            {
                _CustomCapArrow[1].X -= _arrowSize;
                _CustomCapArrow[2].Y -= _arrowSize;
                _CustomCapArrow[3].X += _arrowSize;
            }
            else if (_startPoint.X > _endPoint.X)
            {
                _CustomCapArrow[1].Y -= _arrowSize;
                _CustomCapArrow[2].X -= _arrowSize;
                _CustomCapArrow[3].Y += _arrowSize;
            }
            else
            {
                _CustomCapArrow[1].X -= _arrowSize;
                _CustomCapArrow[2].Y += _arrowSize;
                _CustomCapArrow[3].X += _arrowSize;
            }

            _graphics.DrawLines(_pen, _CustomCapArrow);
        }

        public void CreateCustomCapRhombEnd(bool colorRhomb)
        {
            _CustomCapArrow = new Point[]
             {
                    _endPoint,
                    new Point(_endPoint.X, _endPoint.Y),
                    new Point(_endPoint.X, _endPoint.Y),
                    new Point(_endPoint.X, _endPoint.Y),
                    _endPoint,
             };

            if (_startPoint.X < _endPoint.X)
            {
                _CustomCapArrow[1].X -= _arrowSize;
                _CustomCapArrow[1].Y -= _arrowSize;

                _CustomCapArrow[2].X -= 2 * _arrowSize;

                _CustomCapArrow[3].X -= _arrowSize;
                _CustomCapArrow[3].Y += _arrowSize;
            }
            else if (_startPoint.Y > _endPoint.Y && _startPoint.X == _endPoint.X)
            {
                _CustomCapArrow[1].X += _arrowSize;
                _CustomCapArrow[1].Y += _arrowSize;

                _CustomCapArrow[2].Y += 2 * _arrowSize;

                _CustomCapArrow[3].X -= _arrowSize;
                _CustomCapArrow[3].Y += _arrowSize;
            }
            else if (_startPoint.X > _endPoint.X)
            {
                _CustomCapArrow[1].X += _arrowSize;
                _CustomCapArrow[1].Y -= _arrowSize;

                _CustomCapArrow[2].X += 2 * _arrowSize;

                _CustomCapArrow[3].X += _arrowSize;
                _CustomCapArrow[3].Y += _arrowSize;
            }
            else
            {
                _CustomCapArrow[1].X -= _arrowSize;
                _CustomCapArrow[1].Y -= _arrowSize;

                _CustomCapArrow[2].Y -= 2 * _arrowSize;

                _CustomCapArrow[3].X += _arrowSize;
                _CustomCapArrow[3].Y -= _arrowSize;
            }

            _graphics.DrawPolygon(_pen, _CustomCapArrow);
            ChooseRhombColor(colorRhomb);
        }

        public void CreateCustomCapRhombStart(bool colorRhomb)
        {
            _CustomCapArrow = new Point[]
            {
                    new Point(_startPoint.X, _startPoint.Y),
                    new Point(_startPoint.X, _startPoint.Y),
                    _startPoint,
                    new Point(_startPoint.X, _startPoint.Y),
                    _startPoint,
            };

            if (_startPoint.X < _endPoint.X && _startPoint.Y == _endPoint.Y)
            {

                _CustomCapArrow[1].X += _arrowSize;
                _CustomCapArrow[1].Y -= _arrowSize;

                _CustomCapArrow[2].X += 2 * _arrowSize;

                _CustomCapArrow[3].X += _arrowSize;
                _CustomCapArrow[3].Y += _arrowSize;
            }
            else if (_startPoint.Y > _endPoint.Y && _startPoint.X == _endPoint.X)
            {
                _CustomCapArrow[1].X -= _arrowSize;
                _CustomCapArrow[1].Y -= _arrowSize;

                _CustomCapArrow[2].Y -= 2 * _arrowSize;

                _CustomCapArrow[3].X += _arrowSize;
                _CustomCapArrow[3].Y -= _arrowSize;
            }
            else if (_startPoint.X > _endPoint.X && _startPoint.Y == _endPoint.Y)
            {
                _CustomCapArrow[1].X -= _arrowSize;
                _CustomCapArrow[1].Y -= _arrowSize;

                _CustomCapArrow[2].X -= 2 * _arrowSize;

                _CustomCapArrow[3].X -= _arrowSize;
                _CustomCapArrow[3].Y += _arrowSize;
            }
            else
            {
                _CustomCapArrow[1].X += _arrowSize;
                _CustomCapArrow[1].Y += _arrowSize;

                _CustomCapArrow[2].Y += 2 * _arrowSize;

                _CustomCapArrow[3].X -= _arrowSize;
                _CustomCapArrow[3].Y += _arrowSize;
            }

            _graphics.DrawPolygon(_pen, _CustomCapArrow);
            ChooseRhombColor(colorRhomb);
        }

        public void CreateCustomOpenCapArrow()
        {
            _CustomCapArrow = new Point[]
             {
                    new Point(_endPoint.X, _endPoint.Y),
                    _endPoint,
                    new Point(_endPoint.X, _endPoint.Y)
             };

            if (_startPoint.X < _endPoint.X)
            {
                _CustomCapArrow[0].Y -= _arrowSize;
                _CustomCapArrow[0].X -= _arrowSize;

                _CustomCapArrow[2].Y += _arrowSize;
                _CustomCapArrow[2].X -= _arrowSize;
            }
            else if (_startPoint.Y > _endPoint.Y && _startPoint.X == _endPoint.X)
            {
                _CustomCapArrow[0].Y += _arrowSize;
                _CustomCapArrow[0].X -= _arrowSize;

                _CustomCapArrow[2].Y += _arrowSize;
                _CustomCapArrow[2].X += _arrowSize;
            }
            else if (_startPoint.X > _endPoint.X)
            {
                _CustomCapArrow[0].Y -= _arrowSize;
                _CustomCapArrow[0].X += _arrowSize;

                _CustomCapArrow[2].Y += _arrowSize;
                _CustomCapArrow[2].X += _arrowSize;
            }
            else
            {
                _CustomCapArrow[0].Y -= _arrowSize;
                _CustomCapArrow[0].X += _arrowSize;

                _CustomCapArrow[2].Y -= _arrowSize;
                _CustomCapArrow[2].X -= _arrowSize;
            }

            _graphics.DrawLines(_pen, _CustomCapArrow);
        }
        
        private void ChooseRhombColor(bool colorRhomb)
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

            _graphics.FillPolygon(shadowBrush, _CustomCapArrow);
        }
    }
}