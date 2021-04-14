using ArrowLine.Arrow;
using ArrowLine.Line;
using ArrowLine.Table;
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
        private bool isArrow = true;

        AbstractFigure arrow;
        AbstractTable table;

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
            arrow = new SolidLineArrow(startPoint, endPoint);
            table = new InterfaceTable();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _isMoving = true;
            arrow._startPoint = e.Location;
            arrow._endPoint = e.Location;
            table.startPoint = e.Location;

            pictureBox1.Invalidate();
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
                table.startPoint = e.Location;
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

                if (isArrow)
                {
                    arrow.Draw(_pen, _graphics);
                }
                else
                {
                    table.Draw(_pen, _graphics);
                }

                pictureBox1.Image = _tmpBitmap;
                GC.Collect();
            }
        }

        private void ButtonColor_Click(object sender, EventArgs e)
        {
            Button btnColor = (Button)sender;

            colorDialog1.ShowDialog();
            btnColor.BackColor = colorDialog1.Color;
            _pen.Color = colorDialog1.Color;
        }

        private void trackbar1_Scroll(object sender, EventArgs e)
        {
            _pen.Width = trackBar1.Value;
        }

        private void CheckButtonPressed_Click(object sender, EventArgs e)
        {
            ToolStripButton toolStripButton = (ToolStripButton)sender;

            toolStripGroupButtons.BackgroundImage = toolStripButton.BackgroundImage;
            isArrow = true;

            switch (toolStripButton.Name)
            {
                case nameof(toolStripButtonCloseArrow):
                    arrow = new InheritanceArrow();
                    break;
                case nameof(toolStripButtonEndRhomb):
                    arrow = new AgregationEndArrow();
                    break;
                case nameof(toolStripButtonEndRhombBlack):
                    arrow = new CompositionEndArrow();
                    break;
                case nameof(toolStripButtonStartRhomb1):
                    arrow = new AgregationStartArrow();
                    break;
                case nameof(toolStripButtonStartRhombBlack):
                    arrow = new CompositionStartArrow();
                    break;
                case nameof(toolStripButtonOpenArrow):
                    arrow = new AssociationArrow();
                    break;
                case nameof(toolStripButtonCloseArrowDash):
                    arrow = new ImplementationArrow();
                    break;
                case nameof(toolStripButtonTwoAngleLine):
                    arrow = new TwoAngleLineArrow(arrow._startPoint, arrow._endPoint);
                    break;
            }
        }

        private void CheckTableType_Click(object sender, EventArgs e)
        {
            //Button button = (Button)sender;

            isArrow = false;
            table = new InterfaceTable(table.startPoint);
        }

        private void F_Click(object sender, EventArgs e)
        {
            _tmpBitmap = (Bitmap)_bitmap.Clone();
            _graphics = Graphics.FromImage(_tmpBitmap);
            pictureBox1.Image = _tmpBitmap;

            table.AddField(_pen, _graphics);

            _bitmap = _tmpBitmap;
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _tmpBitmap = (Bitmap)_bitmap.Clone();
            _graphics = Graphics.FromImage(_tmpBitmap);
            pictureBox1.Image = _tmpBitmap;

            table.AddProperty(_pen, _graphics);

            _bitmap = _tmpBitmap;
        }
    }
}
