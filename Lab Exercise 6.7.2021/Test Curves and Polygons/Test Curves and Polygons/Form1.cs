using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test_Curves_and_Polygons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            //Define drawing surfaces
            Graphics DrawCurveLabel = lblDrawCurve.CreateGraphics();
            Graphics DrawClosedCurveLabel = lblDrawClosedCurve.CreateGraphics();
            Graphics FillClosedCurveLabel = lblFillClosedCurve.CreateGraphics();
            Graphics DrawPolygonLabel = lblDrawPolygon.CreateGraphics();
            Graphics FillPolygonLabel = lblFillPolygon.CreateGraphics();

            //Define pen and brush
            Pen PurplePen = new Pen(Color.DarkMagenta, 1);
            SolidBrush GreenBrush = new SolidBrush(Color.DarkGreen);

            //Define the points
            Point[] curvePoints = new Point[] {new Point(10, 30), new Point(35, 35), new Point(75, 80), new Point(120, 20)};

            //Draw shapes
            DrawCurveLabel.DrawCurve(PurplePen, curvePoints);
            DrawClosedCurveLabel.DrawClosedCurve(PurplePen, curvePoints);
            FillClosedCurveLabel.FillClosedCurve(GreenBrush, curvePoints);
            DrawPolygonLabel.DrawPolygon(PurplePen, curvePoints);
            FillPolygonLabel.FillPolygon(GreenBrush, curvePoints);
        }
    }
}
