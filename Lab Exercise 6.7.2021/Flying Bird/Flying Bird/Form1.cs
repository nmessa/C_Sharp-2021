//Lab Exercise 6.7.2021
//Flying Bird
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Flying_Bird
{
    public partial class Form1 : Form
    {
        //Global variables
        //Add code here


        //Create an array that hold image file names
        //Add code here


        public Form1()
        {
            InitializeComponent();
        }

        //Slow down animation
        private void btnSlow_Click(object sender, EventArgs e)
        {
            //Add code here

        }

        //Speed up animation
        private void btnFast_Click(object sender, EventArgs e)
        {
            //ensure no negative interval
            //Add code here

        }

        //Generate next frame of animation
        private void tmrChangeImage_Tick(object sender, EventArgs e)
        {
            
            //Put image into picture box
            //Add code here


            //create rollover or advance image
            //Add code here

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialize imageArray strings
            //Add code here

        }
    }
}
