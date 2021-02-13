//Lab Exercise 2.16.2021 Problem 4
//Author: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatAWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare an array of area codes as strings
            string[] codes = new string[] {"262", "414", "608", "715", "815", "920"};

            //Declare an array of rates as doubles
            double[] rates = new double[] { 0.07, 0.10, 0.05, 0.16, 0.24, 0.14 };

            //Declare variables
            string strBill, areaCode, strRate;
            int minutes, index;
            double bill;

            //Get area  code from user
            //Add code here


            //Find location of area code in the array codes
            //Add code here


            if (index != -1) //Area code found
            {
                //Get minutes talked as an integer
                //Add code here


                //Calculate bill
                //Add code here


                //Convert the bill and rate to currency strings
                //Add code here

                //Output bill
                //Add code here


            }
            else //Area code not found
            {
                //Add code here

            }   
        }
    }
}

//Sample Output
//Enter area code: 414
//Enter the number of minutes talked: 23
//Minutes billed:        23
//Rate:               $0.10
//Total Bill:         $2.30