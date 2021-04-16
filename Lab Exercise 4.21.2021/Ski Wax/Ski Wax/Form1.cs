//Lab Exercise 4.21.2021 Problem 1
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ski_Wax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWax_Click(object sender, EventArgs e)
        {
            //Declare variables
            int temperature;
            string conditions;
            string message;
            string variety = null;
            string group = null;

            //Get temperature from textbox and store as integer
            //Add code here


            //Check for valid temperature
            //if not valid, give message and reset
            if (temperature < -50 || temperature > 100)
            {
                //Add code here


                return;
            }

            //Get selected item from combobox and store in conditions
            //Add code here


            //Determine variety
            switch (conditions)
            {
                //Add code here

            }

            //Determine group
            //Add code here


            //Output the result
            message = "The best wax is: " + variety + " " + group;
            lblType.Text = message;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Add code here


        }
    }
}
