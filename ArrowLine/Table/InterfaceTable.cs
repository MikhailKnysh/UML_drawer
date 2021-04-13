using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ArrowLine.Table
{
    public class InterfaceTable : AbstractTable
    {
        public InterfaceTable()
        {
        }

        public InterfaceTable(Point startPoint)
        {
            this.startPoint = startPoint;
        }

        protected override void AddField()
        {
            throw new NotImplementedException();
        }

        protected override void AddMethod()
        {
            throw new NotImplementedException();
        }

        public override void Draw(Pen pen, Graphics graphics)
        {
            
        }

        protected override void Move()
        {
            throw new NotImplementedException();
        }

        protected override void Resize()
        {
            throw new NotImplementedException();
        }
    }
}
