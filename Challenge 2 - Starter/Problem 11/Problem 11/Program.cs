//C# Challenge 2 Problem 11
//Author: 
//Date: 3.2.2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_11
{
    class Program
    {
        static void Main(string[] args)
        {
            bool answer;
            answer = hotOrCold(120, -1);
            Console.WriteLine(answer);
            answer = hotOrCold(-1, 120);
            Console.WriteLine(answer);
            answer = hotOrCold(2, 120);
            Console.WriteLine(answer);
        }

        static bool hotOrCold(int t1, int t2)
        {
            //Add code here

        }
    }
}

//Output
//True
//True
//False