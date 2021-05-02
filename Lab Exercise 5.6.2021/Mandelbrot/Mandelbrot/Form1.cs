//Lab Exercise 5.6.2021 Problem 4
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mandelbrot
{
    public partial class Form1 : Form
    {
        private bool m_DrawingBox;
        private int m_X1, m_Y1, m_X2, m_Y2;
        private Bitmap m_ZoomingBitmap;
        private Graphics m_ZoomingGraphics;

        //Graphical variables
        private Bitmap m_Bitmap;
        private Graphics m_Graphics = null;

        //Coordinates
        private const double MIN_X = -2.2;
        private const double MAX_X = 1;
        private const double MIN_Y = -1.2;
        private const double MAX_Y = 1.2;
        private double m_Wxmin = MIN_X;
        private double m_Wxmax = MAX_X;
        private double m_Wymin = MIN_Y;
        private double m_Wymax = MAX_Y;

        public const int MaxIterations = 128;

        //Colors
        private Color[] m_Colors;

        public Form1()
        {
            InitializeComponent();
        }

        private void FullScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Add code here


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Add code here


        }

        private void DrawMandelbrot()
        {
            //Add code here


            
        }

        private void AdjustAspect()
        {
            double want_aspect, Picturebox1_aspect;
            double hgt, wid, mid;

            //Add code here


        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //Add code here


        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //Add code here



        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //Add code here


            
        }
    }
}
