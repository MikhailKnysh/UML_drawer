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
    class DeleteCurrentObject : IMouseHandler
    {
        DataPictureBox singltone = DataPictureBox.GetInstance();
        List<AbstractFigure> selectionObjectDelete;
        ISelection selection = new Selection();
        public void OnMouseDown(AbstractFigure abstractFigure, MouseEventArgs e, Form form, ContextMenuStrip contextMenuStrip)
        {


            if (selection.HitTest(e.Location))
            {
                selectionObjectDelete = CollectionFigure.tables.Where(item => item.Selected == true).ToList();
            }


        }

        public void OnMouseMove(AbstractFigure currentFigure, MouseEventArgs e)
        {

        }

        public void OnMouseUp(AbstractFigure currentFigure, MouseEventArgs e)
        {
            for (int i = 0; i < CollectionFigure.tables.Count; i++)
            {
                if (CollectionFigure.tables[i].Selected == true)
                {
                    CollectionFigure.tables.RemoveAt(i);
                }
            }

            singltone.RebaseBitmap();

            foreach (var item in CollectionFigure.tables)
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
