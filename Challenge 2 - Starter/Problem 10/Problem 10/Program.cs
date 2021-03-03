//C# Challenge 2 Problem 10
//Author: 
//Date: 3.2.2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool answer;
            answer = isMult3or7(3);
            Console.WriteLine(answer);
            answer = isMult3or7(14);
            Console.WriteLine(answer);
            answer = isMult3or7(12);
            Console.WriteLine(answer);
            answer = isMult3or7(37);
            Console.WriteLine(answer);
        }

        static bool isMult3or7(int n)
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
