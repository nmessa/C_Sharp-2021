//Lab Exercise 1.25.2021 Problem 3
//Author: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bill
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            const double TAX_RATE = 0.05;
            double myBill, tax, grandTotal;
            string userInput;

            //Get the amout of bill from user
            //Add code here


            //Calculate tax
            //Add code here


            //Calculate grand total
            //Add code here


            //Output the bill
            Console.WriteLine("Your bill: \t${0}", myBill);
            Console.WriteLine("Sales tax: \t${0}", tax);
            Console.WriteLine("Grand total: \t${0}", grandTotal);
        }
    }
}

//Sample Output
//Enter the amount of the bill: 100
//Your bill:      $100
//Sales tax:      $5
//Grand total:    $105
