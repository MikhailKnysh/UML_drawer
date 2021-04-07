using System;
using System.Drawing;
using System.Windows.Forms;

namespace ArrowLine
{
    public partial class Form1 : Form
    {
        private Bitmap _bitmap;
        private Bitmap _tmpBitmap;
        private Graphics _graphics;
        private Pen _pen;
        private int _chooseButton = 0;
        private bool _isMoving = false;
        private Point _startPoint = new Point();
        private Point _endPoint = new Point();

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
            _isMoving = true;
            _startPoint = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _isMoving = false;
            _bitmap = _tmpBitmap;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMoving)
            {
                _endPoint = e.Location;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (_isMoving)
            {
                _tmpBitmap = (Bitmap)_bitmap.Clone();
                _graphics = Graphics.FromImage(_tmpBitmap);
                pictureBox1.Image = _tmpBitmap;

                Line line = new Line(_pen, _startPoint, _endPoint, _graphics);
              
                ArrowCap arrowCap = new ArrowCap(_graphics, _pen, _startPoint, _endPoint);
                line.DrawLine(false);

                switch (_chooseButton)
                {
                    case 0:
                        {
                            arrowCap.CreateCustomCapArrow();
                            break;
                        }
                    case 1:
                        {
                            arrowCap.CreateCustomCapRhombEnd(true);
                            break;
                        }
                    case 2:
                        {
                            arrowCap.CreateCustomCapRhombEnd(false);
                            break;
                        }
                    case 3:
                        {
                            arrowCap.CreateCustomOpenCapArrow();
                            arrowCap.CreateCustomCapRhombStart(true);
                            break;
                        }
                    case 4:
                        {
                            arrowCap.CreateCustomOpenCapArrow();
                            arrowCap.CreateCustomCapRhombStart(false);
                            break;
                        }
                    case 5:
                        {
                            arrowCap.CreateCustomOpenCapArrow();
                            break;
                        }
                    case 6:
                        {
                            arrowCap.CreateCustomCapArrow();
                            line.DrawLine(true);
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

        private void CheckButtonPressed_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Name)
            {
                case "buttonCloseArrow":
                    _chooseButton = 0;
                    break;
                case "buttonEndRhomb":
                    _chooseButton = 1;
                    break;
                case "buttonEndRhombBlack":
                    _chooseButton = 2;
                    break;
                case "buttonStartRhomb1":
                    _chooseButton = 3;
                    break;
                case "buttonStartRhombBlack":
                    _chooseButton = 4;
                    break;
                case "buttonOpenArrow":
                    _chooseButton = 5;
                    break;
                case "buttonCloseArrowDash":
                    _chooseButton = 6;
                    break;
            }
        }
    }
}
