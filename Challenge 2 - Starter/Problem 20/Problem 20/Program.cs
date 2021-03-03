//C# Challenge 2 Problem 20
//Author: 
//Date: 3.2.2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_20
{
    class Program
    {
        static void Main(string[] args)
        {
            bool answer;
            answer = countZ("frizz");
            Console.WriteLine(answer);
            answer = countZ("zane");
            Console.WriteLine(answer);
            answer = countZ("Zazz");
            Console.WriteLine(answer);
            answer = countZ("false");
            Console.WriteLine(answer);
        }

        static bool countZ(string s)
        {
            //Add code here

        }
    }
}

//Output
//True
//False
//True
//False