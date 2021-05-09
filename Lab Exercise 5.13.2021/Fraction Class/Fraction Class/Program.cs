//Lab Exercise 5.13.2021 Problem 2
//Author: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fraction_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction one = new Fraction(3, 4);
            Fraction two = new Fraction(2, 3);
            Fraction three = new Fraction(10, 12);
            one.display();
            two.display();
            three.display();
        }
    }
}

//Output
//3/4 = 0.7500
//2/3 = 0.6667
//5/6 = 0.8333