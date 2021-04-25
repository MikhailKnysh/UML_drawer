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
        ISelection selection = new SelectionRectangle();
        public void OnMouseDown(AbstractFigure abstractFigure, MouseEventArgs e, Form form, ContextMenuStrip contextMenuStrip)
        {

            
                if (selection.HitTest(e.Location))
                {
                    selectionObjectDelete = singltone.tables.Where(item => item.Selected == true).ToList();
                }

           
        }

        public void OnMouseMove(AbstractFigure currentFigure, MouseEventArgs e)
        {
            
        }

        public void OnMouseUp(AbstractFigure currentFigure, MouseEventArgs e)
        {
            for (int i = 0; i < singltone.tables.Count; i++)
            {
                if (singltone.tables[i].Selected == true)
                {
                    singltone.tables.RemoveAt(i);
                }
            }
            singltone.RebaseBitmap();
            foreach (var item in singltone.tables)
            {
                item.ReDrawRectangleBody();
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
