using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Collections.Generic;
using UMLDrawer.Handler;
using UMLDrawer.Abstract;
using UMLDrawer.Factory;

namespace UMLDrawer
{
    public partial class Form1 : Form
    {
        private DataPictureBox dataPictureBox;
        private string buttonName;
        private bool isButtonSelectPressed = false;
        private bool isArrowButtonPressed = true;
        private AbstractFigure currentFigure;
        private IMouseHandler mouseHandler;
        private IFigureFactory currentFactory;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataPictureBox = DataPictureBox.GetInstance();
            dataPictureBox.SetPictureBox(pictureBox1);
            CollectionFigure.collectionFigures = new List<AbstractFigure>();
            currentFactory = new InterfaceTableFactory();
            currentFigure = currentFactory.CreateFigure();
            currentFigure.Color =Color.Black;
            currentFigure.PenWidth = 2;
            dataPictureBox.isMoving = false;
            mouseHandler = new SelectAndMoveMouseHandler();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            dataPictureBox.isMoving = true;

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
                    currentFigure = currentFactory.CreateFigure();
                }
            }
          
            mouseHandler.OnMouseDown(currentFigure, e, this, contextMenuStrip1);
            dataPictureBox.UpdatePictureBox();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            dataPictureBox.isMoving = false;
            dataPictureBox.SetBitmap();
            mouseHandler.OnMouseUp(currentFigure, e);
            dataPictureBox.UpdatePictureBox();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            dataPictureBox.UpdateTmpBitmap();
            mouseHandler.OnMouseMove(currentFigure, e);
            dataPictureBox.UpdatePictureBox();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (dataPictureBox.isMoving)
            {
                mouseHandler.OnPaint(currentFigure, e);
                dataPictureBox.UpdatePictureBox();
            }
        }

        private void ButtonColor_Click(object sender, EventArgs e)
        {
            
            Button buttonColor = sender as Button;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                buttonColor.BackColor = colorDialog1.Color;
                currentFigure.Color = colorDialog1.Color;
            }
        }

        private void trackbar1_Scroll(object sender, EventArgs e)
        {
            Pen currentPen = new Pen(currentFigure.Color,2);
            currentPen.Width = trackBar1.Value;
            currentFigure.PenWidth = currentPen.Width;
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
                    currentFactory = new InheritanceArrowFactory();
                    break;
                case nameof(toolStripButtonEndRhomb):
                    currentFactory = new AggregationEndArrowFactory();
                    break;
                case nameof(toolStripButtonEndRhombBlack):
                    currentFactory = new CompositionEndArrowFactory();
                    break;
                case nameof(toolStripButtonStartRhomb1):
                    currentFactory = new AggregationStartArrowFactory();
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
            mouseHandler = new SelectAndMoveMouseHandler();
        }

        private void toolStripMenuItemAddField_Click(object sender, EventArgs e)
        {
            dataPictureBox.UpdateTmpBitmap();
            var figure = currentFigure as AbstractTable;
            figure.stringDataTable = mouseHandler.OnToolStripMenuItemAddStringDataTable_Click(
                new StringDataForm(labelData: "Field")).ToString();

            figure.AddField();

            dataPictureBox.SetBitmap();
        }

        private void toolStripMenuItemAddProperty_Click(object sender, EventArgs e)
        {
            dataPictureBox.UpdateTmpBitmap();
            var figure = currentFigure as AbstractTable;
            figure.stringDataTable = mouseHandler.OnToolStripMenuItemAddStringDataTable_Click(
               new StringDataForm(labelData: "Property")).ToString();

            figure.AddProperty();

            dataPictureBox.SetBitmap();
        }

        private void toolStripMenuItemAddMethod_Click(object sender, EventArgs e)
        {
            dataPictureBox.UpdateTmpBitmap();
            var figure = currentFigure as AbstractTable;
            figure.stringDataTable = mouseHandler.OnToolStripMenuItemAddStringDataTable_Click(
              new StringDataForm(labelData: "Method")).ToString();

            figure.AddMethod();

            dataPictureBox.SetBitmap();
        }

        private void toolStripMenuItemRename_Click(object sender, EventArgs e)
        {
            dataPictureBox.UpdateTmpBitmap();
            var figure = currentFigure as AbstractTable;
            figure.title = mouseHandler.OnToolStripMenuItemAddStringDataTable_Click(
                new StringDataForm(labelData: "Title")).ToString();

            currentFigure.Draw();

            dataPictureBox.SetBitmap();
        }

        private void CheckButtonPressedTable_Click(object sender, EventArgs e)
        {
            ToolStripButton toolStripButton = (ToolStripButton)sender;

            isButtonSelectPressed = false;
            isArrowButtonPressed = false;

            toolStripGroupButtonsTable.BackgroundImage = toolStripButton.BackgroundImage;
            buttonName = toolStripButton.Name;
            mouseHandler = new DrawTableMouseHandler();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileData = SerializeFile();
                SaveAndLoadProject.SaveFile(saveFileDialog1.FileName, fileData);
            }
        }

        private string SerializeFile()
        {
            string fileData = JsonConvert.SerializeObject(CollectionFigure.collectionFigures, Formatting.Indented,
                 new JsonSerializerSettings
                 {
                     TypeNameHandling = TypeNameHandling.All
                 });
            return fileData;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
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
                CollectionFigure.collectionFigures = JsonConvert.DeserializeObject<List<AbstractFigure>>(fileData,
                    new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.All
                    });
            }

            dataPictureBox.RebaseBitmap();

            foreach (var item in CollectionFigure.collectionFigures)
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

        private void saveAsImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bitmapToSave = dataPictureBox.GetBitmap();
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
            mouseHandler = new DeleteCurrentObjectMouseHandler();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            CollectionFigure.collectionFigures.Clear();
            dataPictureBox.RebaseBitmap();
        }
    }
}
