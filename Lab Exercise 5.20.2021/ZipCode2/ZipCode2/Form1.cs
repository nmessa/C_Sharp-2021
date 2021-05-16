//Lab Exercise 5.20.2021 Problem 2
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace ZipCode2
{
    public partial class Form1 : Form
    {
        //Create two global List variables
        //Add code here

       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Create variables
            string sql, id, zip, city, state;

            //Create a connection string variable
            string sConnection;

            //Setup  database connection
            //Add code here


            //Create City object variable
            //Add code here


            //Create the connection string
            //Add code here


            //Define the SQL query ordering by State then City ascending order
            //Add code here


            //Connect to the database
            //Add code here



            //Create the database command object
            //Add code here


            //Assign the SQL command to the database command object
            //Add code here


            //Connect the SQL command to the database
            //Add code here


            //Start reading the database
            //Add code here


            //Start reading database records
            while (dbReader.Read())
            {
                //Read the database fields and convert to strings
                //Add code here


                //Construct a City object
                //Add code here


                //Add City object to ArrayList
                //Add code here


                //Add field variables to ListBox
                //Add code here

            }

            //Close connection to database
            //Add code here


            //Read in the states to the comboBox collection
            //Add code here



        }

        private void cboStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Create variable to hold name of state
            string theState;

            //Clear the cities ListBox and zips List
            //Add code here


            //Get the state from the ComboBox
            //Add code here


            //Extract the state abbreviation
            //Add code here


            //Check each city in the cities List
            for (int i = 0; i < cities.Count; i++)
            {
                //if the city is in the state then add the city to lstCities
                //and add its zipcode to the zips List
                //Add code here


            }
       }

        private void lstCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Add the selected city zipcode to the ZIP code label
            //Add code here

        }


    }
}
