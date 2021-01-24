using System;

namespace For_6
{
    class ForVar
    {
        static void Main()
        {
            int sum = 0;
            int fact = 1;

            // Compute the factorial of the numbers through 5. 
            for (int i = 1; i <= 5; i++)
            {
                sum += i;  // i is known throughout the loop 
                fact *= i;
            }

            // Here, i is not known. 

            Console.WriteLine("Sum is " + sum);
            Console.WriteLine("Factorial is " + fact);
        }
    }
}
