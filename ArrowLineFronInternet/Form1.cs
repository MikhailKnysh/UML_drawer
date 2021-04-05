using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrowLineFronInternet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PointF mouseStart;
PointF mouseEnd;
private void panel1_MouseDown(object sender, MouseEventArgs e)
{
    mouseStart = new PointF(e.X, e.Y);
}
private void panel1_MouseUp(object sender, MouseEventArgs e)
{
    mouseEnd = new PointF
(e.X, e.Y);
    panel1.CreateGraphics().Clear(Form1.DefaultBackColor);
    DrawArrow(panel1.CreateGraphics(), mouseStart, mouseEnd, Color.Black,
              Convert.ToInt16(txtLineWidth.Text), Convert.ToInt16(txtArrowMultiplier.Text));
}
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
