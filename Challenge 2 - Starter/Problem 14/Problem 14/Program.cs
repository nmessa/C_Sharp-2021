//C# Challenge 2 Problem 14
//Author: 
//Date: 3.2.2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_14
{
    class Program
    {
        static void Main(string[] args)
        {
            bool answer;
            answer = oneInRange(20, 84);
            Console.WriteLine(answer);
            answer = oneInRange(14, 50);
            Console.WriteLine(answer);
            answer = oneInRange(11, 45);
            Console.WriteLine(answer);
            answer = oneInRange(25, 40);
            Console.WriteLine(answer);
        }

        static bool oneInRange(int n1, int n2)
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
