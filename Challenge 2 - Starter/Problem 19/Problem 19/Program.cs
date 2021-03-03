//C# Challenge 2 Problem 19
//Author: 
//Date: 3.2.2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer;
            answer = biggestInRange(78, 95);
            Console.WriteLine(answer);
            answer = biggestInRange(20, 30);
            Console.WriteLine(answer);
            answer = biggestInRange(21, 25);
            Console.WriteLine(answer);
            answer = biggestInRange(28, 28);
            Console.WriteLine(answer);
        }

        static int biggestInRange(int n1, int n2)
        {
            //Add code here

        }
    }
}

//Output
//0
//30
//25
//28
