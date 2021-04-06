using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrowLine
{
    public partial class Form1 : Form
    {

        const int arrowSize = 10;
        Bitmap _bitmap;
        Bitmap _tmpBitmap;
        Graphics _graphics;
        Pen _pen;
        bool isButtonPress = false;
        int chooseButton = 0;
        bool isMoving = false;
        Point startPoint = new Point();
        Point endPoint = new Point();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _pen = new Pen(Color.Black, 2);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isMoving = true;
            startPoint = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;
            _bitmap = _tmpBitmap;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMoving)
            {
                endPoint = e.Location;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (isMoving)
            {
                _tmpBitmap = (Bitmap)_bitmap.Clone();
                _graphics = Graphics.FromImage(_tmpBitmap);
                pictureBox1.Image = _tmpBitmap;

                Point start = startPoint;
                Point cointermediate = new Point(startPoint.X, endPoint.Y);
                Point end = endPoint;
                Point[] points = { start, cointermediate, end };

                _graphics.DrawLines(_pen, points);

                switch (chooseButton)
                {
                    case 1:
                        {
                            CreateCustomCapArrow();
                            break;
                        }
                    case 2:
                        {
                            CreateCustomCapRhomb();
                            break;
                        }
                    case 3:
                        {
                            CreateCustomCapRhombStart();
                            break;
                        }

                }

            }
        }

        private void button_Color_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pictureBox_color.BackColor = colorDialog1.Color;
            _pen.Color = colorDialog1.Color;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _pen.Width = trackBar1.Value;
        }

        private void buttonInheritanceArrow_Click(object sender, EventArgs e)
        {
            chooseButton = 1;
        }

        private void CreateCustomCapArrow()
        {
            Point[] CustomCapArrow = new Point[]
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

        private void buttonAggregationEndRhomb_Click(object sender, EventArgs e)
        {
            chooseButton = 2;
        }

        private void CreateCustomCapRhomb()
        {
            Point[] CustomCapArrow = new Point[]
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

            SolidBrush shadowBrush = new SolidBrush(Color.White);

            _graphics.DrawPolygon(_pen, CustomCapArrow);
            _graphics.FillPolygon(shadowBrush, CustomCapArrow);
        }

        private void buttonAggregationStartRhomb_Click(object sender, EventArgs e)
        {
            chooseButton = 3;
        }
        private void CreateCustomCapRhombStart()
        {
            Point[] CustomCapArrow = new Point[]
             {
                    new Point(startPoint.X, startPoint.Y),
                    new Point(startPoint.X, startPoint.Y),
                    startPoint,
                    new Point(startPoint.X, startPoint.Y),
                    startPoint,
             };

            if (startPoint.X < endPoint.X && startPoint.Y!=endPoint.Y)
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
            else if (startPoint.X > endPoint.X)
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

            SolidBrush shadowBrush = new SolidBrush(Color.White);

            _graphics.DrawPolygon(_pen, CustomCapArrow);
            _graphics.FillPolygon(shadowBrush, CustomCapArrow);
        }
    }
}
