using ArrowLine.Abstract;
using ArrowLine.SelectionObject;
using ArrowLine.Table.StringData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrowLine.Handler
{
    public class ChangeObjectsHandler: IMouseHandler
    {
        DataPictureBox singltone = DataPictureBox.GetInstance();
        List<AbstractFigure> selectionObjectDelete;
        ISelection selection = new Selection();
        public void OnMouseDown(AbstractFigure abstractFigure, MouseEventArgs e, Form form, ContextMenuStrip contextMenuStrip)
        {
            selectionObjectDelete = CollectionFigure.tables.Where(item => item.Selected == true).ToList();
            
        }

        public void OnMouseMove(AbstractFigure currentFigure, MouseEventArgs e)
        {

        }

        public void OnMouseUp(AbstractFigure currentFigure, MouseEventArgs e)
        {
            foreach(AbstractFigure abstractFigure in CollectionFigure.tables)
            {
                if (abstractFigure.Selected == true)
                {
                    abstractFigure.Color = currentFigure.Color;
                    abstractFigure.PenWidth = currentFigure.PenWidth;
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
