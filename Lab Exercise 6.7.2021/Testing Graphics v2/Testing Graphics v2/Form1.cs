using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Testing_Graphics_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDrawHere_Click(object sender, EventArgs e)
        {
            //Draw graphics on a the button control
            Graphics buttonSurface = btnDrawHere.CreateGraphics();
            Pen orangePen = new Pen(Color.OrangeRed, 5);
            int intMaxX = btnDrawHere.Size.Width;
            int intMaxY = btnDrawHere.Size.Height;
            buttonSurface.DrawLine(orangePen, 0, 0, intMaxX, intMaxY);
            buttonSurface.DrawRectangle(orangePen, 0, 0, intMaxX, intMaxY);


            //Draw graphics on the form itself
            Graphics formSurface = this.CreateGraphics();
            Pen purplePen = new Pen(Color.PaleVioletRed, 3);
            purplePen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            formSurface.DrawRectangle(purplePen, 0, 0, 200, 200);
            formSurface.DrawEllipse(purplePen, 0, 0, 200, 200);

            Pen DarkGreenPen = new Pen(Color.DarkGreen, 2);
            formSurface.DrawArc(DarkGreenPen, 0, 0, 100, 100, 0, 180);

        }
    }
}
