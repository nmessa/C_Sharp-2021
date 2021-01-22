//Lab Exercise 1.28.2021 Problem 4
//Author: 

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
            //Declare variables
            string name, ssn, userInput;
            double payRate, gross, fedTax, stateTax, net, hours;
            string strFedTax, strStateTax, strGross, strPayRate, strHours, strNet;

            //Define constants
            const double FED_TAX = 0.15;
            const double STATE_TAX = 0.05;

            //Get input from user
            //Add code here


            //Calculate gross pay
            //Add code here


            //Calculate taxes
            //Add code here


            //Calculate net pay
            //Add code here


            //Create numeric and currency strings
            //Add code here





            //Output report
            Console.WriteLine("Payroll summary for {0}", name);
            Console.WriteLine("SSN: {0}", ssn);
            Console.WriteLine("You worked {0} hours at {1} per hour", strHours, strPayRate);
            Console.WriteLine();
            Console.WriteLine("Gross Pay:              {0}", strGross);
            Console.WriteLine("Federal Witholding:     {0}", strFedTax);
            Console.WriteLine("State Witholding:       {0}", strStateTax);
            Console.WriteLine("------------------------------");
            Console.WriteLine("Net pay:                 {0}", strNet);
        }
    }
}

//Sample Output
//Enter your name: Mary Jones
//Enter your social security number: 123-45-6789
//Enter your hourly pay rate: 21.75
//Enter your hours worked: 35.5
//Payroll summary for Mary Jones
//SSN: 123-45-6789
//You worked 35.50 hours at $21.75 per hour

//Gross Pay:              $772.13
//Federal Witholding:     $115.82
//State Witholding:       $38.61
//------------------------------
//Net pay:                 $617.70
