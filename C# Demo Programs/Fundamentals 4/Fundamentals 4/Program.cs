using System;

namespace Fundamentals_4
{
    class FtoC
    {
        static void Main()
        {
            double f; // holds the temperature in Fahrenheit 
            double c; // holds the temperature in Celsius 

            // Begin with 59 degrees Fahrenheit 
            f = 59.0;

            // convert to Celsius 
            c = 5.0 / 9.0 * (f - 32.0);

            Console.Write(f + " degrees Fahrenheit is ");
            Console.WriteLine(c + " degrees Celsius.");
        }
    }
}
