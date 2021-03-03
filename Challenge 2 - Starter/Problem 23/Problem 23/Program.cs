//C# Challenge 2 Problem 23
//Author: 
//Date: 3.2.2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_23
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            answer = copies("JS", 2);
            Console.WriteLine(answer);
            answer = copies("JS", 3);
            Console.WriteLine(answer);
            answer = copies("JS", 1);
            Console.WriteLine(answer);
        }

        static string copies(string s, int n)
        {
            //Add code here

        }
    }
}

//Output
//JSJS
//JSJSJS
//JS