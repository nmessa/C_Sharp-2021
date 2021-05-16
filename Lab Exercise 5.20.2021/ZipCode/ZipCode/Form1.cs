//Lab Exercise 5.20.2021 Problem 1
//Author: nmessa

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ZipCode
{
    public partial class Form1 : Form
    {
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


            //Create City object and an ArrayList object variables
            //Add code here

            
            //Construct an ArrayList object to hold cities
            List<City> cities = new List<City>();

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


                //Add City object to List
                //Add code here


                //Add field variables to ListBox
                //Add code here

            }

            //Close connection to database
            //Add code here

        }
    }
}
