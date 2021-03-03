//C# Challenge 2 Problem 18
//Author: 
//Date: 3.2.2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_18
{
    class Program
    {
        static void Main(string[] args)
        {
            bool answer;
            answer = inRange(78, 95);
            Console.WriteLine(answer);
            answer = inRange(25, 35);
            Console.WriteLine(answer);
            answer = inRange(40, 50);
            Console.WriteLine(answer);
            answer = inRange(55, 60);
            Console.WriteLine(answer);
        }

        static bool inRange(int n1, int n2)
        {
            //Add code here

        }
    }
}

//Output
//False
//False
//True
//True