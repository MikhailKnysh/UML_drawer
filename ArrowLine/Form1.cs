using ArrowLine.Line;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Collections.Generic;
using ArrowLine.Handler;
using ArrowLine.Abstract;
using ArrowLine.Factory;

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
        Pen pen = new Pen(Brushes.Black, 2);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            singltone = DataPictureBox.GetInstance();
            singltone.SetPictureBox(pictureBox1);
            CollectionFigure.tables = new List<AbstractFigure>();
            currentFactory = new InterfaceTableFactory();
            crntFigure = currentFactory.CreateFigure();
            crntFigure.Color =Color.Black;
            crntFigure.PenWidth = 2;
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

            if (isButtonDeletePressed)
            {
                mouseHandler.OnMouseUp(crntFigure, e);

            }
            else
            {
            mouseHandler.OnMouseUp(crntFigure, e);

            }
            singltone.UpdatePictureBox();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
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
                crntFigure.Color = colorDialog1.Color;

            }

        }

        private void trackbar1_Scroll(object sender, EventArgs e)
        {
            Pen currentPen = new Pen(crntFigure.Color,2);
            currentPen.Width = trackBar1.Value;
            crntFigure.PenWidth = currentPen.Width;
        }

        private void CheckArrowButtonPressed_Click(object sender, EventArgs e)
        {
            isButtonSelectPressed = false;
            isArrowButtonPressed = true;

            ToolStripButton toolStripButton = (ToolStripButton)sender;

            toolStripGroupButtonsArrow.BackgroundImage = toolStripButton.BackgroundImage;
            buttonName = toolStripButton.Name;
            mouseHandler = new DrawArrowMouseHandler();
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
            isButtonDeletePressed = false;
            mouseHandler = new SelectMouseHandler();
        }

        private void toolStripMenuItemAddField_Click(object sender, EventArgs e)
        {
            singltone.UpdateTmpBitmap();
            var figure = crntFigure as AbstractTable;
            figure.stringDataTable = mouseHandler.OnToolStripMenuItemAddStringDataTable_Click(
                new StringDataForm(labelData: "Field")).ToString();

            figure.AddField();


            singltone.SetBitmap();
        }

        private void toolStripMenuItemAddProperty_Click(object sender, EventArgs e)
        {
            singltone.UpdateTmpBitmap();
            var figure = crntFigure as AbstractTable;
            figure.stringDataTable = mouseHandler.OnToolStripMenuItemAddStringDataTable_Click(
               new StringDataForm(labelData: "Property")).ToString();

            figure.AddProperty();

            singltone.SetBitmap();
        }

        private void toolStripMenuItemAddMethod_Click(object sender, EventArgs e)
        {
            singltone.UpdateTmpBitmap();
            var figure = crntFigure as AbstractTable;
            figure.stringDataTable = mouseHandler.OnToolStripMenuItemAddStringDataTable_Click(
              new StringDataForm(labelData: "Method")).ToString();

            figure.AddMethod();

            singltone.SetBitmap();
        }

        private void toolStripMenuItemRename_Click(object sender, EventArgs e)
        {
            singltone.UpdateTmpBitmap();
            var figure = crntFigure as AbstractTable;
            figure.title = mouseHandler.OnToolStripMenuItemAddStringDataTable_Click(
                new StringDataForm(labelData: "Title")).ToString();

            crntFigure.Draw();

            singltone.SetBitmap();
        }

        private void CheckButtonPressedTable_Click(object sender, EventArgs e)
        {
            ToolStripButton toolStripButton = (ToolStripButton)sender;

            isButtonSelectPressed = false;
            isButtonDeletePressed = false;
            isArrowButtonPressed = false;

            toolStripGroupButtonsTable.BackgroundImage = toolStripButton.BackgroundImage;
            buttonName = toolStripButton.Name;
            mouseHandler = new DrawRectangleHandler();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileData = SerializeFile();
                SaveAndLoadProject.SaveFile(saveFileDialog1.FileName, fileData);
            }
        }

        private string SerializeFile()
        {
            string fileData = JsonConvert.SerializeObject(CollectionFigure.tables, Formatting.Indented,
                 new JsonSerializerSettings
                 {
                     TypeNameHandling = TypeNameHandling.All
                 });
            return fileData;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileData = SaveAndLoadProject.OpenFile(openFileDialog1.FileName);
                DeserializeFile(fileData);
            }
        }

        private void DeserializeFile(string fileData)
        {
            if (fileData != String.Empty)
            {
                CollectionFigure.tables = JsonConvert.DeserializeObject<List<AbstractFigure>>(fileData,
                    new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.All
                    });
            }

            singltone.RebaseBitmap();

            foreach (var item in CollectionFigure.tables)
            {
                item.Draw();
            }

        }

        

        private static ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            ImageCodecInfo[] encoders = ImageCodecInfo.GetImageEncoders();

            for (int j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                {
                    return encoders[j];
                }
            }

            return null;
        }

        bool isButtonDeletePressed = false;

    

        private void buttonSaveImage_Click(object sender, EventArgs e)
        {

            Bitmap bitmapToSave = singltone.GetBitmap();
            ImageCodecInfo imageCodecInfo;
            Encoder encoder;
            EncoderParameter encoderParameter;
            EncoderParameters encoderParameters;

            imageCodecInfo = GetEncoderInfo("image/jpeg");
            encoder = Encoder.Quality;
            encoderParameters = new EncoderParameters(1);

            encoderParameter = new EncoderParameter(encoder, 75L);
            encoderParameters.Param[0] = encoderParameter;
            bitmapToSave.Save("Shapes075.jpg", imageCodecInfo, encoderParameters);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            mouseHandler = new DeleteCurrentObject();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            CollectionFigure.tables.Clear();
            singltone.RebaseBitmap();
        }
    }
}
