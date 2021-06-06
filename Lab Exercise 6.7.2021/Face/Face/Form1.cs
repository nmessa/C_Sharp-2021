//Lab Exercise 6.7.2021
//Face Generator
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Face
{
    public partial class Form1 : Form
    {
        bool blnSwitch = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnHappy_Click(object sender, EventArgs e)
        {
            //Enable wink timer and wink button
            //Add code here



            //Create Graphics surface on PictureBox
            //Add code here


            //Get width and height of graphics surface
            //Add code here


            //draw rectangle in background of picturebox
            //Add code here


            //draw large ellipse for face
            //Add code here


            //draw eyes
            //Add code here



            //draw nose
            //Add code here


            //draw mouth
            //Add code here

        }

        private void btnSad_Click(object sender, EventArgs e)
        {
            //Enable wink timer and wink button
            //Add code here


            //Create Graphics surface on PictureBox
            //Add code here


            //Get width and height of graphics surface
            //Add code here


            //draw rectangle in background of picturebox
            //Add code here


            //draw large ellipse for face
            //Add code here


            //draw eyes
            //Add code here


            //draw nose
            //Add code here


            //draw mouth
            //Add code here

        }

        private void btnWink_Click(object sender, EventArgs e)
        {
            //Add code here

        }

        private void tmrWink_Tick(object sender, EventArgs e)
        {
            //create Graphics surface on PictureBox
            //Add code here


            //get width and height of PictureBox
            //Add code here


            if (blnSwitch)  //erase eye
            {
                //Add code here


            }
            else
            {
                //erase wink
                //Add code here


                //draw open eye
                //Add code here

            }
        }
    }
}
