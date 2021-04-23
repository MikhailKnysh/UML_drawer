using ArrowLine.Line;
using System;
using System.Windows.Forms;

namespace ArrowLine
{
    public partial class Form1 : Form
    {
        DataPictureBox singltone;
        string buttonName;
        bool isButtonSelectPressed = false;
        bool isArrowButtonPressed = true;
        AbstractFigure crntFigure;
        IMouseHandler mouseHandler;
        IFigureFactory currentFactory;
        public string stringDataTable;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            singltone = DataPictureBox.GetInstance();
            singltone.SetPictureBox(pictureBox1);
            singltone.InitialList();
            currentFactory = new InterfaceTableFactory();
            crntFigure = currentFactory.CreateFigure();
            singltone.isMoving = false;
            mouseHandler = new SelectMouseHandler();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            singltone.isMoving = true;

            if (!isButtonSelectPressed)
            {
                if (isArrowButtonPressed)
                {
                    ChooseArrowButton();
                }
                else
                {
                    ChooseTableButton();
                }

                if (e.Button == MouseButtons.Left)
                {
                    crntFigure = currentFactory.CreateFigure();
                }
            }

            mouseHandler.OnMouseDown(crntFigure, e, this, contextMenuStrip1);
            singltone.UpdatePictureBox();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            singltone.isMoving = false;
            singltone.SetBitmap();
            mouseHandler.OnMouseUp(crntFigure, e);
            singltone.UpdatePictureBox();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {

            }
            singltone.UpdateTmpBitmap();
            mouseHandler.OnMouseMove(crntFigure, e);
            
            singltone.UpdatePictureBox();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (singltone.isMoving)
            {
                mouseHandler.OnPaint(crntFigure, e);
                singltone.UpdatePictureBox();
            }
        }

        private void ButtonColor_Click(object sender, EventArgs e)
        {
            Button btnColor = sender as Button;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = colorDialog1.Color;
                singltone.pen.Color = colorDialog1.Color;

            }

        }

        private void trackbar1_Scroll(object sender, EventArgs e)
        {
            singltone.pen.Width = trackBar1.Value;
        }

        private void CheckArrowButtonPressed_Click(object sender, EventArgs e)
        {
            isButtonSelectPressed = false;
            isArrowButtonPressed = true;

            ToolStripButton toolStripButton = (ToolStripButton)sender;

            toolStripGroupButtonsArrow.BackgroundImage = toolStripButton.BackgroundImage;
            buttonName = toolStripButton.Name;
            mouseHandler = new DrawMouseHandler();
        }

        private void ChooseArrowButton()
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

        private void ChooseTableButton()
        {
            switch (buttonName)
            {
                case nameof(toolStripButtonClassTable):
                    currentFactory = new ClassTableFactory();
                    break;
                case nameof(toolStripButtonInterfaceTable):
                    currentFactory = new InterfaceTableFactory();
                    break;
                case nameof(toolStripButtonStackTable):
                    currentFactory = new StackTableFactory();
                    break;
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            isButtonSelectPressed = true;
            mouseHandler = new SelectMouseHandler();
        }

        private void toolStripMenuItemAddField_Click(object sender, EventArgs e)
        {
            singltone.UpdateTmpBitmap();

            crntFigure.stringDataTable = mouseHandler.OnToolStripMenuItemAddStringDataTable_Click(
                new StringDataForm(labelData: "Field")).ToString();

            crntFigure.AddField();


            singltone.SetBitmap();
        }

        private void toolStripMenuItemAddProperty_Click(object sender, EventArgs e)
        {
            singltone.UpdateTmpBitmap();
            crntFigure.stringDataTable = mouseHandler.OnToolStripMenuItemAddStringDataTable_Click(
               new StringDataForm(labelData: "Property")).ToString();

            crntFigure.AddProperty();

            singltone.SetBitmap();
        }

        private void toolStripMenuItemAddMethod_Click(object sender, EventArgs e)
        {
            singltone.UpdateTmpBitmap();
            crntFigure.stringDataTable = mouseHandler.OnToolStripMenuItemAddStringDataTable_Click(
              new StringDataForm(labelData: "Method")).ToString();

            crntFigure.AddMethod();

            singltone.SetBitmap();
        }

        private void toolStripMenuItemRename_Click(object sender, EventArgs e)
        {
            singltone.UpdateTmpBitmap();

            crntFigure.title = mouseHandler.OnToolStripMenuItemAddStringDataTable_Click(
                new StringDataForm(labelData: "Title")).ToString();

            crntFigure.Draw();

            singltone.SetBitmap();
        }

        private void CheckButtonPressedTable_Click(object sender, EventArgs e)
        {
            ToolStripButton toolStripButton = (ToolStripButton)sender;

            isButtonSelectPressed = false;
            isArrowButtonPressed = false;

            toolStripGroupButtonsTable.BackgroundImage = toolStripButton.BackgroundImage;
            buttonName = toolStripButton.Name;
            mouseHandler = new DrawMouseHandler();
        }
    }
}
