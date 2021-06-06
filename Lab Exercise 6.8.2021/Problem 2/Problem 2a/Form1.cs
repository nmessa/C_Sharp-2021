//Lab Exercise 6.8.2021 Problem 2
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Problem_2a
{
    public partial class Form1 : Form
    {
        //Create two lists, countries and capitals
        //Add code here

        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Create FileStream and StreamReader to read capitals.txt
            //Add code here

            
            //Declare local variables
            int listSize = 0;   //Needed to keep track of the size of the lists
            string[] temp;

            //Read first line to prime the loop
            //Add code here


            //Keep looping until you run out of lines of text
            while (line != null)
            {
                //Break line up into country and capital
                //Add code here


                //Add country and capital to their respective lists
                //Add code here


                //Read in the next line
                //Add code here

            }
            //Close the StreamReader and FileStream
            //Add code here


            //Add the countries to the ComboBox items
            //Add code here

        }

        //This method will place the capital of the selected country into the label
        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Add code here

        }


        //This method will exit the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Add code here

        }
    }
}
