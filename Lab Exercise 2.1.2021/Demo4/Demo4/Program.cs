using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string userInput, answer;
            Console.Write("Enter a number: ");
            userInput = Console.ReadLine();
            number = Convert.ToInt32(userInput);
            
            answer = (number % 2 == 1) ? "Odd" : "Even";
            Console.WriteLine(answer);
        }
    }
}
