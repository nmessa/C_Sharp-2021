//Lab Exercise 5.13.2021 Problem 2
//Fraction Class 
//Author: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fraction_Class
{
    class Fraction
    {
        //Class member variables
        private int numerator;
        private int denominator;
        private double decimalEquivalent;

        public Fraction(int num, int den)
        {
            //Add code here

        }

        public void display()
        {
            //Add code here
        }

        private void reduce(int a, int b)
        {
            //Add code here


        }

        //This method implements Euclid's Algorithm
        private int gcd(int a, int b)
        {
            int t;

            while (b > 0)
            {
                t = b;
                b = a % b;
                a = t;
            }

            return a;
        }
    }
}
