using System;

namespace ContinueDemo
{
    class Program
    {
        static void Main()
        {
            int i;

            // Print even number between 0 and 100. 
            for (i = 0; i <= 100; i++)
            {

                // Iterate if i is odd. 
                if ((i % 2) != 0) continue;

                Console.WriteLine(i);
            }
        }   
    }
}
