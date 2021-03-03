//C# Challenge 2 Problem 16
//Author: 
//Date: 3.2.2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer;
            answer = largest(1, 2, 3);
            Console.WriteLine(answer);
            answer = largest(1, 3, 2);
            Console.WriteLine(answer);
            answer = largest(1, 1, 1);
            Console.WriteLine(answer);
            answer = largest(1, 2, 2);
            Console.WriteLine(answer);
        }

        static int largest(int n1, int n2, int n3)
        {
            //Add code here

        }
    }
}

//Output
//3
//3
//1
//2