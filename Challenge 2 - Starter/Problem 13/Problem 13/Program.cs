//C# Challenge 2 Problem 13
//Author: 
//Date: 3.2.2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_13
{
    class Program
    {
        static void Main(string[] args)
        {
            bool answer;
            answer = oneInRange(11, 20, 12);
            Console.WriteLine(answer);
            answer = oneInRange(30, 30, 17);
            Console.WriteLine(answer);
            answer = oneInRange(25, 35, 50);
            Console.WriteLine(answer);
            answer = oneInRange(15, 12, 8);
            Console.WriteLine(answer);
        }

        static bool oneInRange(int n1, int n2, int n3)
        {
            //Add code here

        }
    }
}

//Output
//True
//True
//True
//False

