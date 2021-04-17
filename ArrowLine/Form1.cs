using ArrowLine.Arrow;
using ArrowLine.Line;
using ArrowLine.Table;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace ArrowLine
{
    public partial class Form1 : Form
    {
        private Bitmap _bitmap;
        private Bitmap _tmpBitmap;
        private Graphics _graphics;
        string buttonName;
        private Pen _pen;
        bool isButtonSelectPressed = false;
        private bool _isMoving = false;
        private bool isArrow = true;
        Point startPoint = new Point();
        Point endPoint = new Point();
        private Brush _highlightBrush;
        private Pen _highlightPen;
        AbstractFigure crntFigure;
        AbstractTable table;
        List<AbstractTable> figures;

        public WorkingMode Mode
        {
            get
            {
                if (isButtonSelectPressed)
                {
                    return WorkingMode.Select;
                }
                else
                {
                    return WorkingMode.Draw;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            _isMoving = false;

            _highlightBrush = new SolidBrush(Color.FromArgb(50, Color.Aquamarine));
            _highlightPen = new Pen(Color.Navy);
            _highlightPen.DashStyle = DashStyle.Dash;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            figures = new List<AbstractTable>();
            
            _bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            _graphics = Graphics.FromImage(_bitmap);
            _graphics.Clear(Color.White);
            pictureBox1.Image = _bitmap;

            _pen = new Pen(Color.Black, 2);
            crntFigure = new SolidLineArrow(startPoint, endPoint);
            table = new InterfaceTable();//Add to draw moment
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ChooseButton();

            _isMoving = true;
            if (isButtonSelectPressed)
            {
                startPoint = e.Location;
            }
            else
            {
                crntFigure._startPoint = e.Location;
                crntFigure._endPoint = e.Location;
                table._startPoint = e.Location;
            }

            if (isButtonSelectPressed)
            {
                AbstractTable selectedObject = null;

                foreach (var item in figures)
                {
                    item.Selected = false;

                    if (item.HitTest(e.Location))
                    {
                        selectedObject = item;
                    }
                }

                if (selectedObject != null)
                {
                    selectedObject.Selected = true;
                }
            }

            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _bitmap = _tmpBitmap;
            _isMoving = false;

            switch (Mode)
            {
                case WorkingMode.Draw:
                    if (table != null)
                    {
                        figures.Add(table);
                    }
                    break;

                case WorkingMode.Select: // Множественное выделение объектов
                    Rectangle r = new Rectangle(
                       Math.Min(startPoint.X, endPoint.X),
                       Math.Min(startPoint.Y, endPoint.Y),
                       Math.Abs(startPoint.X - endPoint.X),
                       Math.Abs(startPoint.Y - endPoint.Y));

                    foreach (AbstractTable item in figures)
                        item.Selected = item.HitTest(r);
                    break;
            }

            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMoving)
            {
                crntFigure._endPoint = e.Location;
               endPoint = e.Location;
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

                switch (Mode)
                {
                    case WorkingMode.Select:

                        Rectangle r = new Rectangle(
                         Math.Min(startPoint.X, endPoint.X),
                       Math.Min(startPoint.Y, endPoint.Y),
                       Math.Abs(startPoint.X - endPoint.X),
                       Math.Abs(startPoint.Y - endPoint.Y));

                        e.Graphics.FillRectangle(_highlightBrush, r);
                        e.Graphics.DrawRectangle(_highlightPen, r);

                        //if (figures.Any())
                        //{
                        //    if (table.Selected)
                        //    {
                        //        figures.First().DrawOverlay(_graphics);
                        //    }
                        //}

                        foreach (var item in figures)
                        {
                            if (table.Selected)
                            {
                                table.DrawOverlay(_graphics);
                            }
                        }
                        break;

                    case WorkingMode.Draw:

                        if (isArrow)
                        {
                            crntFigure.Draw(_pen, _graphics);
                        }
                        else
                        {
                            table.Draw(_pen, _graphics);
                        }

                        break;
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
            isButtonSelectPressed = false;

            ToolStripButton toolStripButton = (ToolStripButton)sender;

            toolStripGroupButtons.BackgroundImage = toolStripButton.BackgroundImage;
            isArrow = true;
            buttonName = toolStripButton.Name;
           
        }
        private void ChooseButton()
        {
            switch (buttonName)
            {
                case nameof(toolStripButtonCloseArrow):
                    crntFigure = new InheritanceArrow();
                    break;
                case nameof(toolStripButtonEndRhomb):
                    crntFigure = new AgregationEndArrow();
                    break;
                case nameof(toolStripButtonEndRhombBlack):
                    crntFigure = new CompositionEndArrow();
                    break;
                case nameof(toolStripButtonStartRhomb1):
                    crntFigure = new AgregationStartArrow();
                    break;
                case nameof(toolStripButtonStartRhombBlack):
                    crntFigure = new CompositionStartArrow();
                    break;
                case nameof(toolStripButtonOpenArrow):
                    crntFigure = new AssociationArrow();
                    break;
                case nameof(toolStripButtonCloseArrowDash):
                    crntFigure = new ImplementationArrow();
                    break;
                case nameof(toolStripButtonTwoAngleLine):
                    crntFigure = new TwoAngleLineArrow(crntFigure._startPoint, crntFigure._endPoint);
                    break;
                case "table":
                    table = new InterfaceTable();
                    break;
            }

        }

        private void CheckTableType_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            isArrow = false;
            isButtonSelectPressed = false;
            buttonName = button.Name;

            foreach (var item in figures)
            {
                item.Selected = false;
            }

            pictureBox1.Refresh();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            isButtonSelectPressed = true;
        }
    }
}
