using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Testing_Graphics_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDrawHere_Click(object sender, EventArgs e)
        {
            Graphics buttonSurface = this.btnDrawHere.CreateGraphics();
            Pen OrangePen = new Pen(Color.OrangeRed, 5);
            int intMaxX = this.btnDrawHere.Size.Width;
            int intMaxY = this.btnDrawHere.Size.Height;
            buttonSurface.DrawLine(OrangePen, 0, 0, intMaxX, intMaxY);
            buttonSurface.DrawRectangle(OrangePen, 0, 0, intMaxX, intMaxY);

            Graphics formSurface = this.CreateGraphics();
            Pen purplePen = new Pen(Color.PaleVioletRed, 3);
            formSurface.DrawRectangle(purplePen, 0, 0, 200, 200);
            formSurface.DrawEllipse(purplePen, 0, 0, 200, 200);

            Pen darkGreenPen = new Pen(Color.DarkGreen, 2);
            formSurface.DrawArc(darkGreenPen, 0, 0, 100, 100, 0, 180);
        }
    }
}
