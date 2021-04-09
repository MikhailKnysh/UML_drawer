using ArrowLine.Arrow;
using ArrowLine.Line;
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
        private bool _isMoving = false;

        AbstractArrow arrow;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Point startPoint = new Point();
            Point endPoint = new Point();

            _bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _pen = new Pen(Color.Black, 2);
            arrow = new SolidLine(startPoint,endPoint);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _isMoving = true;
            arrow._startPoint = e.Location;
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
                arrow._endPoint = e.Location;
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

                arrow.Draw(_pen, _graphics);

                pictureBox1.Image = _tmpBitmap;
                GC.Collect();


            }
        }

        private void button_Color_Click(object sender, EventArgs e)
        {
            Button btnColor = (Button)sender;
            colorDialog1.ShowDialog();
            btnColor.BackColor = colorDialog1.Color;
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
                case nameof(buttonCloseArrow):
                    arrow = new InheritanceArrow();
                    break;
                case nameof(buttonEndRhomb):
                    arrow = new AgregationEndArrow();
                    break;
                case nameof(buttonEndRhombBlack):
                    arrow = new CompositionEndArrow();
                    break;
                case nameof(buttonStartRhomb1):

                    arrow = new AgregationStartArrow();
                    break;
                case nameof(buttonStartRhombBlack):
                    arrow = new CompositionStartArrow();
                    break;
                case nameof(buttonOpenArrow):
                    arrow = new AssociationArrow();
                    break;
                case nameof(buttonCloseArrowDash):
                    arrow = new ImplementationArrow();
                    break;
                case nameof(buttonTwoAngleLine):
                    arrow = new TwoAngleLine(arrow._startPoint,arrow._endPoint);
                    break;
            }
        }

    }
}
