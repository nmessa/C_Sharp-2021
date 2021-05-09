//Lab Exercise 5.12.2021 Problem 2
//Author: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            int t1, t2;

            //Print a table to compare Rule of 72 estimation to actual
            //interest compounding
            Console.WriteLine("Rate   Rule 72    Years to double");
            for (int r = 1; r <= 20; r++)
            {
                t1 = ruleOf72(r);
                t2 = yearsToDouble(r);
                Console.WriteLine(r + "        " + t1 + "            " + t2);
            }
        }

        //This function implements the Rule of 72
        static int ruleOf72(int rate)
        {
            int years;
            //Add code here


            return years;
        }

        //This function calculates the years if takes for
        //primciple to double
        static int yearsToDouble(double rate)
        {
            //Add code here

            
        }
    }
}

//Output
//Rate   Rule 72    Years to double
//1        72            70
//2        36            36
//3        24            24
//4        18            18
//5        14            15
//6        12            12
//7        10            11
//8        9            10
//9        8            9
//10        7            8
//11        6            7
//12        6            7
//13        5            6
//14        5            6
//15        4            5
//16        4            5
//17        4            5
//18        4            5
//19        3            4
//20        3            4