//C# Challenge 2 Problem 6
//Author: 
//Date: 3.2.2021 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            answer = removeChar("Python", 1);
            Console.WriteLine(answer);
            answer = removeChar("Python", 0);
            Console.WriteLine(answer);
            answer = removeChar("Python", 4);
            Console.WriteLine(answer);
        }

        static string removeChar(string s, int index)
        {
            //Add code here

        }
    }
}

//Output
//Pthon
//ython
//Pythn
