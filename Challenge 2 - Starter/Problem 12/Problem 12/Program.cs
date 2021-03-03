//C# Challenge 2 Problem 12
//Author: 
//Date: 3.2.2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_12
{
    class Program
    {
        static void Main(string[] args)
        {
            bool answer;
            answer = inRange(100, 199);
            Console.WriteLine(answer);
            answer = inRange(250, 300);
            Console.WriteLine(answer);
            answer = inRange(105, 190);
            Console.WriteLine(answer);
        }

        static bool inRange(int n1, int n2)
        {
            //Add code here

        }
    }
}

//Output
//True
//False
//True