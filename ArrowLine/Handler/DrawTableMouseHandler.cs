using ArrowLine.Abstract;
using ArrowLine.Table.StringData;
using System.Drawing;
using System.Windows.Forms;

namespace ArrowLine.Handler
{
    public class DrawTableMouseHandler : IMouseHandler
    {
        public DataPictureBox dataPictureBox = DataPictureBox.GetInstance();
        private IDTO _idto;

        public void OnMouseDown(AbstractFigure currentFigure, MouseEventArgs e, Form form, ContextMenuStrip contextMenuStrip)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentFigure.StartPoint = e.Location;
                currentFigure.EndPoint = e.Location;
            }

            if (e.Button == MouseButtons.Right)
            {
                dataPictureBox.isMoving = false;
                contextMenuStrip.Show(form, new Point(e.X + 120, e.Y));
            }
        }

        public void OnMouseMove(AbstractFigure currentFigure, MouseEventArgs e)
        {
            currentFigure.EndPoint = e.Location;
        }

        public void OnMouseUp(AbstractFigure currentFigure, MouseEventArgs e)
        {
            if (currentFigure != null && e.Button == MouseButtons.Left)
            {
                CollectionFigure.collectionFigures.Add(currentFigure);
            }
        }

        public void OnPaint(AbstractFigure currentFigure, PaintEventArgs e)
        {
            currentFigure.Draw();
        }

        public IDTO OnToolStripMenuItemAddStringDataTable_Click(StringDataForm stringDataForm)
        {
            stringDataForm.ShowDialog();
            _idto = stringDataForm.Create();
            return _idto;
        }
    }
}
