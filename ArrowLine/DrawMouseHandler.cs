using System.Drawing;
using System.Windows.Forms;
using ArrowLine.Table.StringData;

namespace ArrowLine
{
    public class DrawMouseHandler : IMouseHandler
    {
        public DataPictureBox singltone = DataPictureBox.GetInstance();
        private IDTO _idto;

        public void OnMouseDown(AbstractFigure currentFigure, MouseEventArgs e, Form form, ContextMenuStrip contextMenuStrip)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    {
                        currentFigure.startPoint = e.Location;
                        currentFigure.endPoint = e.Location;
                    }
                    break;
                case MouseButtons.Right:
                    {
                        singltone.isMoving = false;
                        contextMenuStrip.Show(form, new Point(e.X + 120, e.Y));
                        break;
                    }
            }
        }

        public void OnMouseMove(AbstractFigure currentFigure, MouseEventArgs e)
        {
            currentFigure.endPoint = e.Location;
        }

        public void OnMouseUp(AbstractFigure currentFigure, MouseEventArgs e)
        {
            if (currentFigure != null)
            {
                singltone.tables.Add(currentFigure);
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

        //private void ChooseButton()
        //{
        //    switch (buttonName)
        //    {
        //        case nameof(toolStripButtonCloseArrow):
        //            currentFactory = new InharitanceArrowFactory();
        //            break;
        //        case nameof(toolStripButtonEndRhomb):
        //            currentFactory = new AgregationEndArrowFactory();
        //            break;
        //        case nameof(toolStripButtonEndRhombBlack):
        //            currentFactory = new CompositionEndArrowFactory();
        //            break;
        //        case nameof(toolStripButtonStartRhomb1):
        //            currentFactory = new AgregationStartArrowFactory();
        //            break;
        //        case nameof(toolStripButtonStartRhombBlack):
        //            currentFactory = new CompositionStartArrowFactory();
        //            break;
        //        case nameof(toolStripButtonOpenArrow):
        //            currentFactory = new AssociationArrowFactory();
        //            break;
        //        case nameof(toolStripButtonCloseArrowDash):
        //            currentFactory = new ImplementationArrowFactory();
        //            break;
        //        case nameof(toolStripButtonTwoAngleLine):
        //            crntFigure = new TwoAngleLineArrow();
        //            break;
        //    }
    }
}
