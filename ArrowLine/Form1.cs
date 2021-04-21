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
        List<AbstractFigure> selectionObject;
        IMouseHandler mouseHandler;
        IFigureFactory currentFactory;
        ISelection selection;

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
            List<AbstractFigure> figurs;
            singltone.InitialList();
            currentFactory = new InterfaceTableFactory();
            crntFigure = currentFactory.CreateFigure();
            singltone.isMoving = false;
            selection = new Selection();
            IMouseHandler mouseHandler = new DrawMouseHandler();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ChooseButton();

            if (isButtonSelectPressed)
            {
                switch (e.Button)
                {
                    case MouseButtons.Left:
                        {
                            startPoint = e.Location;
                            endPoint = startPoint;

                            if (selectionObject != null)                                  //если нажать и двигать, то перемещать обьект и не обнулять лист
                            {
                                DrawSelection(Brushes.White, selectionObject);
                                selectionObject = null;

                                foreach (var item in singltone.tables)
                                {
                                    item.Selected = false;
                                }
                            }

                            if (selection.HitTest(e.Location))
                            {
                                selectionObject = singltone.tables.Where(item => item.Selected == true).ToList();
                            }
                        }
                        break;
                    case MouseButtons.Right:
                        {
                            if (selectionObject != null)
                            {
                                foreach (AbstractFigure item in selectionObject)
                                {
                                    item.startPoint = new Point(Cursor.Position.X, Cursor.Position.Y);
                                }
                            }
                            break;
                        }
                }
                //need remove item selected from singltone.tables?
            }
            else
            {
                crntFigure = currentFactory.CreateFigure();

                mouseHandler.OnMouseDown(crntFigure, e, this, contextMenuStrip1);
            }

            singltone.isMoving = true;
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

            // Множественное выделение объектов
            if (isButtonSelectPressed)
            {
                switch (e.Button)
                {
                    case MouseButtons.Left:

                        Rectangle r = new Rectangle(
                              Math.Min(startPoint.X, endPoint.X),
                              Math.Min(startPoint.Y, endPoint.Y),
                              Math.Abs(startPoint.X - endPoint.X),
                              Math.Abs(startPoint.Y - endPoint.Y));


                        if (selection.HitTest(r) == true)
                        {
                            selectionObject = singltone.tables.Where(item => item.Selected == true).ToList();
                        }

                        if (selectionObject != null)
                        {
                            DrawSelection(Brushes.Black, selectionObject);
                        }
                        break;
                    case MouseButtons.Right:
                        //if (selectionObject != null)
                        //{
                        //    foreach (AbstractFigure item in selectionObject)
                        //    {
                        //        item.startPoint = new Point(Cursor.Position.X, Cursor.Position.Y);
                        //    }
                        //}
                        break;
                }
            }
            else
            {
                mouseHandler.OnMouseUp(crntFigure);
            }

            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (singltone.isMoving)
            {
                    endPoint = e.Location;

                if (isButtonSelectPressed)
                {


                    if (selectionObject != null)
                    {
                        foreach (AbstractFigure item in selectionObject)
                        {
                            item.Move(e.X - item.endPoint.X, e.Y - item.endPoint.Y);
                        }
                    }

                    foreach (var item in singltone.tables)
                    {
                        item.Selected = false;
                    }
                }
                else
                {
                    mouseHandler.OnMouseMove(crntFigure, e);
                }

                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (singltone.isMoving)
            {
                if (isButtonSelectPressed)
                {
                   
                    Rectangle r = new Rectangle(
                      Math.Min(startPoint.X, endPoint.X),
                      Math.Min(startPoint.Y, endPoint.Y),
                      Math.Abs(startPoint.X - endPoint.X),
                      Math.Abs(startPoint.Y - endPoint.Y));

                    e.Graphics.FillRectangle(_highlightBrush, r);
                    e.Graphics.DrawRectangle(_highlightPen, r);

                }
                else
                {
                    mouseHandler.OnPaint(crntFigure);
                }

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

        private void DrawSelection(Brush brush, List<AbstractFigure> abstractFigures)
        {
            foreach (var abstractFigure in abstractFigures)
            {
                selection.DrawOverlay(brush, abstractFigure);
            }
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
                    currentFactory = new InharitanceArrowFactory();
                    break;
                case nameof(toolStripButtonEndRhomb):
                    currentFactory = new AgregationEndArrowFactory();
                    break;
                case nameof(toolStripButtonEndRhombBlack):
                    currentFactory = new CompositionEndArrowFactory();
                    break;
                case nameof(toolStripButtonStartRhomb1):
                    currentFactory = new AgregationStartArrowFactory();
                    break;
                case nameof(toolStripButtonStartRhombBlack):
                    currentFactory = new CompositionStartArrowFactory();
                    break;
                case nameof(toolStripButtonOpenArrow):
                    currentFactory = new AssociationArrowFactory();
                    break;
                case nameof(toolStripButtonCloseArrowDash):
                    currentFactory = new ImplementationArrowFactory();
                    break;
                case nameof(toolStripButtonTwoAngleLine):
                    crntFigure = new TwoAngleLineArrow();
                    break;
            }

        }

        private void CheckTableType_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            isArrow = false;
            isButtonSelectPressed = false;

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
