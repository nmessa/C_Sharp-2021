using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo3
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
            {
                Console.WriteLine("Invalid score entered");
                Environment.Exit(0);
            }

            score = score / 10;
            switch (score)
            {
                case 10:
                    Console.WriteLine("A");
                    break;
                case 9:
                    Console.WriteLine("A");
                    break;
                case 8:
                    Console.WriteLine("B");
                    break;
                case 7:
                    Console.WriteLine("C");
                    break;
                case 6:
                    Console.WriteLine("D");
                    break;
                default:
                    Console.WriteLine("F");
                    break;
            }
        }
    }
}
