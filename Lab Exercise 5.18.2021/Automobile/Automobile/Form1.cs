//Lab Exercise 5.18.2021
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Automobile
{
    public partial class Form1 : Form
    {
        //Create a global Automobile object
        //Add code here


        //Create a global Color object
        //Add code here


        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            //Declare variables
            string make, temp;
            int speed, heading, hp;
            string message = "";

            //Get car info
            //Add code here


            //Update Automobile object
            //Add code here


            //Create Automobile information object
            message += "Make: " + myCar.getMake() + Environment.NewLine;
            message += "Color: " + temp.Substring(7, temp.Length - 8) + Environment.NewLine;
            message += "Horsepower: " + myCar.getHP().ToString() + Environment.NewLine;
            message += "Speed: " + myCar.getSpeed().ToString() + Environment.NewLine;
            message += "Heading: " + myCar.getHeading().ToString();

            //Display Autombile object information
            MessageBox.Show(message);

            //Reset all values
            //Add code here

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Construct Automobile object
            //Add code here

        }

        private void btnPaint_Click(object sender, EventArgs e)
        {
            //Set the color of the car using ColorDialog
            //Add code here

        }

        private void trkSpeed_Scroll(object sender, EventArgs e)
        {
            //Set the speed
            //Add code here

        }

        private void trkHeading_Scroll(object sender, EventArgs e)
        {
            //Set the heading
            //Add code here

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //Set the horsepower
            //Add code here

        }
    }
}
