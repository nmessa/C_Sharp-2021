//Substring Demo 2
//Author: nmessa
//Date: 2/11/2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Substring_Demo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "This is a test";
            int index;
            string word;

            while (s.Contains(' '))
            {
                index = s.IndexOf(' ');
                word = s.Substring(0, index);
                Console.WriteLine(word);
                s = s.Substring(index+1);
            }
            Console.WriteLine(s);
        }
    }
}

//Output
//This
//is
//a
//test
