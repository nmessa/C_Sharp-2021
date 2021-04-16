//Lab Exercise 4.21.2021 Problem 2
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Half_Life
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAge_Click(object sender, EventArgs e)
        {
            //Declare variables
            double age, halfLife, initialCount, finalCount;

            //Get values from textboxes
            //Add code here

            //Check for invalid data
            if (initialCount < finalCount)
            {
                MessageBox.Show("Invalid data");
                //Reset textboxes and set focus to txtHalfLife
                txtFinalCount.Text = "";
                txtHalfLife.Text = "";
                txtInitialCount.Text = "";
                txtHalfLife.Focus();
                return;
            }

            //Calculate age
            //Add code here


            //Store result in label
            //Add code here


            //Reset textboxes and set focus to txtHalfLife
            //Add code here

        }
    }
}
