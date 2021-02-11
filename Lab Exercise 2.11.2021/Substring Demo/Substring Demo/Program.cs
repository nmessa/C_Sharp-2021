//Substring Demo
//Author: nmessa
//Date: 2/11/2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Substring_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            string testString = "Mary Jones";
            int index;
            string first, last;

            //Find location of space character
            index = testString.IndexOf(' ');

            //use Substring to get first and last name
            first = testString.Substring(0, index);
            last = testString.Substring(index + 1);

            //Output name
            Console.WriteLine(first + " " + last);
        }
    }
}
