using System;

namespace Fundamentals_8
{
    class FtoCTable
    {
        static void Main()
        {
            double f, c;
            int counter;

            counter = 0;
            for (f = 0.0; f < 100.0; f++)
            {

                // Convert to Celsius 
                c = 5.0 / 9.0 * (f - 32.0);

                Console.WriteLine(f + " degrees Fahrenheit is " +
                                  c + " degrees Celsius.");

                counter++;

                // Every 10th line, print a blank line. 
                if (counter == 10)
                {
                    Console.WriteLine();
                    counter = 0; // reset the line counter 
                }
            }
        }
    }
}
