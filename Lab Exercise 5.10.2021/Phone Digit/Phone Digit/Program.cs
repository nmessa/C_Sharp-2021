//Lab Exercise 5.10.2021 Problem 1
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Phone_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter;
            int number;
            Console.WriteLine("Enter a letter");
            letter = Convert.ToChar(Console.ReadLine());
            letter = Char.ToUpper(letter);
            number = convert(letter);
            Console.WriteLine(number);
        }

        private static int convert(char ch)
        {
            int number=0;
            //Add code here



            return number;
        }
    }
}
