using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;
            string userInput;
            Console.Write("Enter a test score (1 - 100): ");
            userInput = Console.ReadLine();
            score = Convert.ToInt32(userInput);
            if (score < 0 || score > 100)
                Console.WriteLine("Invalid score entered");
            else if (score >= 90)
                Console.WriteLine("A");
            else if (score >= 80)
                Console.WriteLine("B");
            else if (score >= 70)
                Console.WriteLine("C");
            else if (score >= 60)
                Console.WriteLine("D");
            else
                Console.WriteLine("F");
        }
    }
}
