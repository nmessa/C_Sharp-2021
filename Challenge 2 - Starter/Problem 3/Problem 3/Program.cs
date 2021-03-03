//C# Challenge 2 Problem 3
//Author: 
//Date: 3.2.2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool answer;
            answer = thirty(30, 0);
            Console.WriteLine(answer);
            answer = thirty(25, 5);
            Console.WriteLine(answer);
            answer = thirty(20, 30);
            Console.WriteLine(answer);
            answer = thirty(20, 25);
            Console.WriteLine(answer);
        }

        static bool thirty(int n1, int n2)
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
