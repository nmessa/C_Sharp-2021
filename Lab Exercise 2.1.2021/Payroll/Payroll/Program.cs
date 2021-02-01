//Lab exercise 1.28.2020 Problem 5
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare varaiables
            double hours, hourlyRate, gross, tax, net;
            string userInput;
            string strGross, strHourlyRate, strTax, strNet, strHours;

            //Define constants
            const double TAX1 = 0.1;
            const double TAX2 = 0.12;
            

            //Get hourly rate from user and convert to double
            //Add code here


            //Get hours worked from user and convert to double
            //Add code here


            //Calculate gross pay
            //Add code here


            //Determine tax
            //Add code here


            //Calculate net pay
            //Add code here


            //Create formatted strings
            //Add code here


            //Output report
            Console.WriteLine("You worked {0} hours at {1} per hour", strHours, strHourlyRate);
            Console.WriteLine();
            Console.WriteLine("Gross Pay:          {0}", strGross);
            Console.WriteLine("Witholding Tax      {0}", strTax);
            Console.WriteLine("Net Pay:            {0}", strNet);
        }
    }
}

//Sample Output
//Enter hourly rate: 23.45
//Enter hours worked: 38.25
//You worked 38.25 hours at $23.45 per hour

//Gross Pay:          $896.96
//Witholding Tax      $107.64
//Net Pay:            $789.33