//Lab Exercise 5.4.2021 Problem 1
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "ASANTAATNASA";    //Palindrome
            string string2 = "HELP ME";          //Not a palindrome
            if (isPalindrome(string1))
                Console.WriteLine("It is a palindrome");
            else
                Console.WriteLine("It is not a palindrome");


            if (isPalindrome(string2))
                Console.WriteLine("It is a palindrome");
            else
                Console.WriteLine("It is not a palindrome");
        }

        private static bool isPalindrome(string str)
        {
            //Add code here


        }
    }
}

//Output
//It is a palindrome
//It is not a palindrome