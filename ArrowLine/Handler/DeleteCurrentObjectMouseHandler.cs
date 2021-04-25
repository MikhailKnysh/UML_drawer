using ArrowLine.Abstract;
using ArrowLine.SelectionObject;
using ArrowLine.Table.StringData;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrowLine.Handler
{
    public class DeleteCurrentObjectMouseHandler : IMouseHandler
    {
        DataPictureBox dataPictureBox = DataPictureBox.GetInstance();
        List<AbstractFigure> selectedObjectDelete;
        ISelection selection = new Selection();

        public void OnMouseDown(AbstractFigure currentFigure, MouseEventArgs e, Form form, ContextMenuStrip contextMenuStrip)
        {
            if (selection.HitObjectArea(e.Location))
            {
                selectedObjectDelete = CollectionFigure.collectionFigures.Where(item => item.Selected == true).ToList();
            }
        }

        public void OnMouseMove(AbstractFigure currentFigure, MouseEventArgs e)
        {
        }

        public void OnMouseUp(AbstractFigure currentFigure, MouseEventArgs e)
        {
            for (int i = 0; i < CollectionFigure.collectionFigures.Count; i++)
            {
                if (CollectionFigure.collectionFigures[i].Selected == true)
                {
                    CollectionFigure.collectionFigures.RemoveAt(i);
                }
            }

            dataPictureBox.RebaseBitmap();

            foreach (var item in CollectionFigure.collectionFigures)
            {
                if (item.Type == FigureType.Table)
                {
                    (item as AbstractTable).ReDrawRectangleBody();
                }

                item.Draw();
            }
        }

        public void OnPaint(AbstractFigure currentFigure, PaintEventArgs e)
        {
        }

        public IDTO OnToolStripMenuItemAddStringDataTable_Click(StringDataForm stringDataForm)
        {
            throw new NotImplementedException();
        }
    }
}
