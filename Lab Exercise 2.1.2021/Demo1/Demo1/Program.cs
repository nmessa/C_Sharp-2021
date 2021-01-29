using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string userInput;
            Console.Write("Enter a number: ");
            userInput = Console.ReadLine();
            number = Convert.ToInt32(userInput);
            if (number % 2 == 1)
                Console.WriteLine("Odd");
            else
                Console.WriteLine("Even");
        }
    }
}
