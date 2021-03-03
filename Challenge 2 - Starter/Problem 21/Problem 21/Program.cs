//C# Challenge 2 Problem 21
//Author: 
//Date: 3.2.2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_21
{
    class Program
    {
        static void Main(string[] args)
        {
            bool answer;
            answer = lastDigit(123, 456);
            Console.WriteLine(answer);
            answer = lastDigit(12, 512);
            Console.WriteLine(answer);
            answer = lastDigit(7, 87);
            Console.WriteLine(answer);
            answer = lastDigit(12, 45);
            Console.WriteLine(answer);
        }

        static bool lastDigit(int n1, int n2)
        {
            //Add code here

        }
    }
}

//Output
//False
//True
//True
//False