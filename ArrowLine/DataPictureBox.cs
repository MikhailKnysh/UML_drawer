using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ArrowLine
{
    public class DataPictureBox
    {
        private static DataPictureBox _instance;
        private PictureBox _pictureBox;
        private Bitmap _bitmap;
        private Bitmap _tmpbitmap;

        public bool isMoving { get; set; }

        public static DataPictureBox GetInstance()
        {
            if (_instance is null)
            {
                _instance = new DataPictureBox();
            }

            return _instance;
        }

        public void SetPictureBox(PictureBox pictureBox1)
        {
            GraficPictureBox.pen = new Pen(Color.Black, 2);
            _pictureBox = pictureBox1;
            _bitmap = new Bitmap(_pictureBox.Width, _pictureBox.Height);
            _tmpbitmap = (Bitmap)_bitmap.Clone();
            GraficPictureBox.Graphics = Graphics.FromImage(_bitmap);
            pictureBox1.Image = _bitmap;
            _pictureBox.BackColor = Color.White;
            _pictureBox.Image = _tmpbitmap;
        }

        public void UpdateTmpBitmap()
        {
            _tmpbitmap = (Bitmap)_bitmap.Clone();
            GraficPictureBox.Graphics = Graphics.FromImage(_tmpbitmap);
            _pictureBox.Image = _tmpbitmap;
        }

        public void SetBitmap()
        {
            _bitmap = _tmpbitmap;
        }

        public void UpdatePictureBox()
        {
            _pictureBox.Image = _tmpbitmap;
        }

        public void RebaseBitmap()
        {
            _bitmap = new Bitmap(_pictureBox.Width, _pictureBox.Height);
            GraficPictureBox.Graphics = Graphics.FromImage(_bitmap);
            GraficPictureBox.Graphics.Clear(Color.White);
            _pictureBox.Image = _bitmap;
        }

        public Bitmap GetBitmap()
        {
            return _bitmap;
        }
    }
}
