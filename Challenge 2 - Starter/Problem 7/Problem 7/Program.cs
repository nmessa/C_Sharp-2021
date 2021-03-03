//C# Challenge Problem 7
//Author: 
//Date: 3.2.2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            answer = swapFirstAndLast("abcd");
            Console.WriteLine(answer);
            answer = swapFirstAndLast("a");
            Console.WriteLine(answer);
            answer = swapFirstAndLast("xy");
            Console.WriteLine(answer);
        }

        static string swapFirstAndLast(string s)
        {
            //Add code here

        }
    }
}

//Output
//dbca
//a
//yx
