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
        DataPictureBox singltone;
        string buttonName;
        bool isButtonSelectPressed = false;
        //private bool _isMoving = false;
        private bool isArrow = true;
        Point startPoint = new Point();
        Point endPoint = new Point();
        private Brush _highlightBrush;
        private Pen _highlightPen;
        AbstractFigure crntFigure;
        AbstractTable table;
        //List<AbstractTable> figures;
        List<AbstractFigure> figurs;
        IMouseHandler mouseHandler;

        IFigureFactory currentFactory;//

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



            _highlightBrush = new SolidBrush(Color.FromArgb(50, Color.Aquamarine));
            _highlightPen = new Pen(Color.Navy);
            _highlightPen.DashStyle = DashStyle.Dash;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            singltone = DataPictureBox.GetInstance();
            singltone.SetPictureBox(pictureBox1);
            //figures = new List<AbstractTable>();

            List<AbstractFigure> figurs;
            singltone.InitialList();
            crntFigure = new SolidLineArrow(startPoint, endPoint);
            singltone.isMoving = false;
            //table = new InterfaceTable();


            IMouseHandler mouseHandler = new DrawMouseHandler();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
             ChooseButton();
            singltone.isMoving = true;

            crntFigure = currentFactory.CreateFigure();

            mouseHandler.OnMouseDown(crntFigure, e, this, contextMenuStrip1);
            //switch (e.Button)
            //{
            //    case MouseButtons.Left:
            //        {




            //            crntFigure.startPoint = e.Location;
            //            crntFigure.endPoint = e.Location;
            //            table.startPoint = e.Location;


            //            break;
            //        }
            //    case MouseButtons.Right:
            //        {

            //            contextMenuStrip1.Show(this, new Point(e.X + 120, e.Y));
            //            break;
            //        }
            //}

            //if (isButtonSelectPressed)
            //{
            //    startPoint = e.Location;
            //    AbstractTable selectedObject = null;

            //    foreach (var item in figures)
            //    {
            //        item.Selected = false;

            //        if (item.HitTest(e.Location))
            //        {
            //            selectedObject = item;
            //        }
            //    }

            //    if (selectedObject != null)
            //    {
            //        selectedObject.Selected = true;
            //    }
            //}

            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
           //foreach(var item in figures)
           // {
           //     item.Selected = false;
           // }

            singltone.isMoving = false;
            singltone.SetBitmap();

            switch (Mode)
            {
                case WorkingMode.Draw:

                    mouseHandler.OnMouseUp(crntFigure);
                    //if (table != null)
                    //{
                    //    figurs.Add(table);
                    //}
                    break;

                //case WorkingMode.Select: // Множественное выделение объектов
                //    Rectangle r = new Rectangle(
                //       Math.Min(startPoint.X, endPoint.X),
                //       Math.Min(startPoint.Y, endPoint.Y),
                //       Math.Abs(startPoint.X - endPoint.X),
                //       Math.Abs(startPoint.Y - endPoint.Y));

                //    foreach (AbstractTable item in figurs)
                //        item.Selected = item.HitTest(r);
                //    break;
            }

            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (singltone.isMoving)
            {
                mouseHandler.OnMouseMove(crntFigure, e);
                //crntFigure.endPoint = e.Location;
                endPoint = e.Location;
                //table.singltone.startPoint = e.Location;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (singltone.isMoving)
            {
                //_tmpBitmap = (Bitmap)_bitmap.Clone();
                //_graphics = Graphics.FromImage(_tmpBitmap);
                //pictureBox1.Image = _tmpBitmap;
                singltone.UpdateTmpBitmap();
                mouseHandler.OnPaint(crntFigure);

                //switch (Mode)
                //{
                //    case WorkingMode.Select:

                //        Rectangle r = new Rectangle(
                //         Math.Min(startPoint.X, endPoint.X),
                //       Math.Min(startPoint.Y, endPoint.Y),
                //       Math.Abs(startPoint.X - endPoint.X),
                //       Math.Abs(startPoint.Y - endPoint.Y));

                //        e.Graphics.FillRectangle(_highlightBrush, r);
                //        e.Graphics.DrawRectangle(_highlightPen, r);

                //        //if (figures.Any())
                //        //{
                //        //    if (table.Selected)
                //        //    {
                //        //        figures.First().DrawOverlay(_graphics);
                //        //    }
                //        //}

                //        foreach (var item in figures)
                //        {
                //            if (item.Selected)
                //            {
                //                item.DrawOverlay();
                //            }
                //        }
                //        break;

                //case WorkingMode.Draw:
                //MouseEventArgs a = new MouseEventArgs(MouseButtons.None);
                //switch(a.Button)
                //{
                //    case MouseButtons.Left:
               // crntFigure.Draw();
                       // break;

                //}


                       // break;
                }

                singltone.UpdatePictureBox();
               
                GC.Collect();
            //}
        }

        private void ButtonColor_Click(object sender, EventArgs e)
        {
            Button btnColor = (Button)sender;

            colorDialog1.ShowDialog();
            btnColor.BackColor = colorDialog1.Color;
            singltone.pen.Color = colorDialog1.Color;
        }

        private void trackbar1_Scroll(object sender, EventArgs e)
        {
            singltone.pen.Width = trackBar1.Value;
        }

        private void CheckButtonPressed_Click(object sender, EventArgs e)
        {
            isButtonSelectPressed = false;

            ToolStripButton toolStripButton = (ToolStripButton)sender;

            toolStripGroupButtons.BackgroundImage = toolStripButton.BackgroundImage;
            isArrow = true;
            buttonName = toolStripButton.Name;
            mouseHandler = new DrawMouseHandler();

            //ChooseButton();

        }
        private void ChooseButton()
        {
            switch (buttonName)
            {
                case nameof(toolStripButtonCloseArrow):
                    //crntFigure = new InheritanceArrow();
                    currentFactory = new InharitanceArrowFactory();//
                    break;
                case nameof(toolStripButtonEndRhomb):
                    //crntFigure = new AgregationEndArrow();
                    currentFactory = new AgregationEndArrowFactory();//
                    break;
                case nameof(toolStripButtonEndRhombBlack):
                    //crntFigure = new CompositionEndArrow();
                    currentFactory = new CompositionEndArrowFactory();//
                    break;
                case nameof(toolStripButtonStartRhomb1):
                    //crntFigure = new AgregationStartArrow();
                    currentFactory = new AgregationStartArrowFactory();//
                    break;
                case nameof(toolStripButtonStartRhombBlack):
                    //crntFigure = new CompositionStartArrow();
                    currentFactory = new CompositionStartArrowFactory();//
                    break;
                case nameof(toolStripButtonOpenArrow):
                    //crntFigure = new AssociationArrow();
                    currentFactory = new AssociationArrowFactory();//
                    break;
                case nameof(toolStripButtonCloseArrowDash):
                    //crntFigure = new ImplementationArrow();
                    currentFactory = new ImplementationArrowFactory();//
                    break;
                case nameof(toolStripButtonTwoAngleLine):
                    crntFigure = new TwoAngleLineArrow();
                    break;
                //case "table":
                //    table = new InterfaceTable();
                //    break;
            }

        }

        private void CheckTableType_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            isArrow = false;
            isButtonSelectPressed = false;
            //table = new InterfaceTable();

            currentFactory = new InterfaceTableFactory();//
           // table = (AbstractTable)crntFigure;

            buttonName = button.Name;
            mouseHandler = new DrawMouseHandler();
            //foreach (var item in figures)
            //{
            //    item.Selected = false;
            //}

            //pictureBox1.Refresh();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            isButtonSelectPressed = true;
        }

        private void toolStripMenuItemAddField_Click(object sender, EventArgs e)
        {
            singltone.UpdateTmpBitmap();


            crntFigure.AddField();

            singltone.SetBitmap();
        }

        private void toolStripMenuItemAddProperty_Click(object sender, EventArgs e)
        {
            singltone.UpdateTmpBitmap();

            crntFigure.AddProperty();

            singltone.SetBitmap();
        }

        private void toolStripMenuItemAddMethod_Click(object sender, EventArgs e)
        {
            singltone.UpdateTmpBitmap();

            crntFigure.AddMethod();

            singltone.SetBitmap();
        }
    }
}
