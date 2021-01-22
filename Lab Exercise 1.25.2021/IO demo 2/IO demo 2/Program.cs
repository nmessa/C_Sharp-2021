using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IO_demo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String first, middle, last;
            Console.Write("Enter your first name: ");
            first = Console.ReadLine();
            Console.Write("Enter your middle name: ");
            middle = Console.ReadLine();
            Console.Write("Enter your last name: ");
            last = Console.ReadLine();
            Console.WriteLine("First name: {0}\nMiddle name: {1}\nLast name: {2}", first, middle, last);
        }
    }
}
