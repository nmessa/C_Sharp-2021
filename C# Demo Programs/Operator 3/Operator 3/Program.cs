using System;

namespace Operator_3
{
    class SCops
    {
        static void Main()
        {
            int n, d;

            n = 10;
            d = 2;

            // Here, d is 2, so the modulus operation takes place. 
            if (d != 0 && (n % d) == 0)
                Console.WriteLine(d + " is a factor of " + n);

            d = 0; // now, set d to zero 

            // Since d is zero, the second operand is not evaluated. 
            if (d != 0 && (n % d) == 0)
                Console.WriteLine(d + " is a factor of " + n);

            // Now, try same thing without short-circuit operator. 
            // This will cause a divide-by-zero error. 
            if (d != 0 & (n % d) == 0)
                Console.WriteLine(d + " is a factor of " + n);
        }
    }
}
