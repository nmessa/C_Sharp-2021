//Lab Exercise 6.4.2021
//Author: nmessa

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Planet_Weight
{
    public partial class Form1 : Form
    {
        //conversion table
        double[] convert = new double[] {0.4155, 0.8975, 1.0, 0.166, 0.3507, 2.5375, 1.0677, 0.8947, 1.1794,
                                   0.0899, 0.000000000578, 0.00000000195};
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //create variables
            int weight;
            double planetWeight;
            string message;

            //get weight from text box
            //Add code here


            //Convert weight to planetWeight using conversion table
            //Add code here


            //Create message to display
            //Add code here


            //Display the message
            //Add code here


            //Clear weight textbox and set focus to textbox
            //Add code here

        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            btnConvert.Enabled = true;
        }
    }
}
