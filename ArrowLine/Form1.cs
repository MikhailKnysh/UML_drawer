﻿using ArrowLine.Arrow;
using ArrowLine.Line;
using ArrowLine.Table;
using ArrowLine.Table.StringData;
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
        private StringDataForm stringDataForm;
        public string stringDataTable;
        private IDTO _idto;

        private AbstractFigure arrow;
        private AbstractTable table;

        public Form1()
        {
            InitializeComponent();
        }

        //public Form1(StringDataForm resultForm) => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            Point startPoint = new Point();
            Point endPoint = new Point();
            _bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _pen = new Pen(Color.Black, 1);
            arrow = new SolidLineArrow(startPoint, endPoint);
            table = new InterfaceTable();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    {
                        _isMoving = true;
                        arrow._startPoint = e.Location;
                        arrow._endPoint = e.Location;
                        table.startPoint = e.Location;
                        break;
                    }
                case MouseButtons.Right:
                    {
                        contextMenuStrip1.Show(this, new Point(e.X + 120, e.Y));
                        break;
                    }
            }

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

              // pictureBox1.Image = _tmpBitmap;
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
            Font font = new Font("Arial", 12);

           /* Pen dpen = new Pen(Color.FromArgb(128, 0, 0, 0), 1);
            dpen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            _graphics.DrawRectangle(dpen, new Rectangle(100, 100, 100, 100));
            Point[] points = new Point[] {
                new Point(100,
                    100),

                new Point(200,
                    100),

                new Point(200,
                    200),

                new Point(100,
                    200),
            };

            SolidBrush shadowBrush = new SolidBrush(Color.White);

            _graphics.DrawPolygon(new Pen(Color.White), points);
            _graphics.FillPolygon(shadowBrush, points);*/
            _graphics.DrawString("Test", font, new SolidBrush(Color.Black), new Rectangle(200, 200, 200, 200));
            
        

        //table.AddField(_pen, _graphics);

            _bitmap = _tmpBitmap;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _tmpBitmap = (Bitmap)_bitmap.Clone();
            _graphics = Graphics.FromImage(_tmpBitmap);
            pictureBox1.Image = _tmpBitmap;

            table.AddProperty(_pen, _graphics);

            _bitmap = _tmpBitmap;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _tmpBitmap = (Bitmap)_bitmap.Clone();
            _graphics = Graphics.FromImage(_tmpBitmap);
            pictureBox1.Image = _tmpBitmap;

            table.AddMethod(_pen, _graphics);

            _bitmap = _tmpBitmap;
        }

        private void toolStripMenuItemAddField_Click(object sender, EventArgs e)
        {
            stringDataForm = new StringDataForm(labelData: "Field");
            stringDataForm.ShowDialog();
            _idto = stringDataForm.Create();
            table.stringDataTable = _idto.ToString();

            _tmpBitmap = (Bitmap)_bitmap.Clone();
            _graphics = Graphics.FromImage(_tmpBitmap);
            pictureBox1.Image = _tmpBitmap;

            table.AddField(_pen, _graphics);

            _bitmap = _tmpBitmap;
        }

        private void toolStripMenuItemAddProperty_Click(object sender, EventArgs e)
        {
            stringDataForm = new StringDataForm(labelData: "Property");
            stringDataForm.ShowDialog();
            _idto = stringDataForm.Create();
            table.stringDataTable = _idto.ToString();

            _tmpBitmap = (Bitmap)_bitmap.Clone();
            _graphics = Graphics.FromImage(_tmpBitmap);
            pictureBox1.Image = _tmpBitmap;

            table.AddProperty(_pen, _graphics);

            _bitmap = _tmpBitmap;
        }

        private void toolStripMenuItemAddMethod_Click(object sender, EventArgs e)
        {
            stringDataForm = new StringDataForm(labelData: "Method");
            stringDataForm.ShowDialog();
            _idto = stringDataForm.Create();
            table.stringDataTable = _idto.ToString();

            _tmpBitmap = (Bitmap)_bitmap.Clone();
            _graphics = Graphics.FromImage(_tmpBitmap);
            pictureBox1.Image = _tmpBitmap;

            table.AddMethod(_pen, _graphics);

            _bitmap = _tmpBitmap;
        }
    }
}
