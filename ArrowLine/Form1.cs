using ArrowLine.Arrow;
using ArrowLine.Line;
using System;
using System.Collections.Generic;
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

        AbstractArrow crntArrow;
        List<AbstractArrow> arrowsList;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Point startPoint = new Point();
            Point endPoint = new Point();
            arrowsList = new List<AbstractArrow>();

            _bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _pen = new Pen(Color.Black, 2);
            crntArrow = new SolidLineArrow(startPoint,endPoint)
                ;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _isMoving = true;
            crntArrow._startPoint = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _isMoving = false;
            _bitmap = _tmpBitmap;
            arrowsList.Add(crntArrow);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMoving)
            {
                crntArrow._endPoint = e.Location;
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

                crntArrow.Draw(_pen, _graphics);

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
            
            switch (toolStripButton.Name)
            {
                case nameof(toolStripButtonCloseArrow):
                    crntArrow = new InheritanceArrow();
                    break;
                case nameof(toolStripButtonEndRhomb):
                    crntArrow = new AgregationEndArrow();
                    break;
                case nameof(toolStripButtonEndRhombBlack):
                    crntArrow = new CompositionEndArrow();
                    break;
                case nameof(toolStripButtonStartRhomb1):
                    crntArrow = new AgregationStartArrow();
                    break;
                case nameof(toolStripButtonStartRhombBlack):
                    crntArrow = new CompositionStartArrow();
                    break;
                case nameof(toolStripButtonOpenArrow):
                    crntArrow = new AssociationArrow();
                    break;
                case nameof(toolStripButtonCloseArrowDash):
                    crntArrow = new ImplementationArrow();
                    break;
                case nameof(toolStripButtonTwoAngleLine):
                    crntArrow = new TwoAngleLineArrow(crntArrow._startPoint, crntArrow._endPoint);
                    break;
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            _tmpBitmap = (Bitmap)_bitmap.Clone();
            _graphics = Graphics.FromImage(_tmpBitmap);
            _graphics.Clear(Color.White);
            pictureBox1.Image = _tmpBitmap;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            _tmpBitmap = (Bitmap)_bitmap.Clone();
            _graphics = Graphics.FromImage(_tmpBitmap);

            foreach(var arrow in arrowsList)
            {
                
                arrow.Draw(_pen, _graphics);
            }

            pictureBox1.Image = _tmpBitmap;
        }
    }
}
