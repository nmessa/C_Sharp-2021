using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test_Solid_Graphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
        Graphics FormSurface = this.CreateGraphics();
        SolidBrush purpleBrush = new SolidBrush(Color.BlueViolet);
        FormSurface.FillPie(purpleBrush, 0, 210, 50, 50, 0, 180);    //half circle

        SolidBrush hotPinkBrush = new SolidBrush(Color.HotPink);
        FormSurface.FillRectangle(hotPinkBrush, 0, 0, 200, 200);

        SolidBrush greenBrush = new SolidBrush(Color.GreenYellow);
        FormSurface.FillEllipse(greenBrush, 0, 0, 200, 200);
        }
    }
}
