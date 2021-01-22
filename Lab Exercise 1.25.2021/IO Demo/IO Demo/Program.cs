using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IO_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            double value;
            String userInput;

            //Get floating point number from user
            Console.Write("Enter a floating point number: ");
            userInput = Console.ReadLine();
            value = Convert.ToDouble(userInput);

            //Output the result
            Console.WriteLine("The number your entered was {0}",value);

            //Get cost of candy bar from user
            Console.Write("Enter the cost of a candy bar: ");
            userInput = Console.ReadLine();
            value = Convert.ToDouble(userInput);

            //Output the result
            Console.WriteLine("The cost of a candy bar is {0}", value.ToString("C"));
        }
    }
}

//Sample Output
//Enter a floating point number: 3.56
//The number your entered was 3.56
//Enter the cost of a candy bar: 2.49
//The cost of a candy bar is $2.49
