using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowLine
{
    public class Selection
    {
        public DataPictureBox singltone = DataPictureBox.GetInstance();
        Rectangle objectRectangle;
        Region objectRegion;

        public Rectangle ObjectRectangle
        {
            get { return objectRectangle; }
            set
            {
                objectRectangle = value;
                objectRegion = new Region(objectRectangle);
            }
        }

        public void InitialRegion()
        {
            //foreach(AbstractFigure item in singltone.tables)
            //{
            //    ObjectRectangle = item;
            //    item = new Region();
            //}
        }
    }
}
