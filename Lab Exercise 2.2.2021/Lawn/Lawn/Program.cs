//Lab Exercise 2.2.2021 Problem 1
//Author: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lawn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            int length, width, area, fee, totalFee;
            string userInput, strTotalFee, strFee;

            //Define constant for number of weeks in the season
            const int NUM_WEEKS = 20;

            //Get length of lawn and convert to 32 bit integer
            //Add code here


            //Get width of lawn and convert to 32 bit integer
            //Add code here


            //Calculate are of lawn
            //Add code here


            //Determine the fee
            //Add code here



            //Calculate the total fee for the season
            //Add code here


            //Create currency strings to be used in output
            //Add code here


            //Output the weekly fee and fee for season
            Console.WriteLine("Weekly Fee:        {0}", strFee);
            Console.WriteLine("Fee for season     {0}", strTotalFee);
        }
    }
}
//Sample Output
//Enter the length of the lawn: 40
//Enter the width of the lawn: 40
//Weekly Fee:        $50.00
//Fee for season     $1,000.00

//Enter the length of the lawn: 20
//Enter the width of the lawn: 25
//Weekly Fee:        $35.00
//Fee for season     $700.00

//Enter the length of the lawn: 15
//Enter the width of the lawn: 20
//Weekly Fee:        $25.00
//Fee for season     $500.00