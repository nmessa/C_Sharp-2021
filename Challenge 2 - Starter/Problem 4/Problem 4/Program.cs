//C# Challenge 2 Problem 4
//Author: 
//Date: 3.2.2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool answer;
            answer = isClose(103);
            Console.WriteLine(answer);
            answer = isClose(90);
            Console.WriteLine(answer);
            answer = isClose(89);
            Console.WriteLine(answer);
            answer = isClose(203);
            Console.WriteLine(answer);
        }

        static bool isClose(int n)
        {
            //Add code here

        }
    }
}

//Output
//True
//True
//False
//True