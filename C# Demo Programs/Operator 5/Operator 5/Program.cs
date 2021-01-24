using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Operator_5
{
    class SideEffects
    {
        static void Main()
        {
            int i;

            i = 0;

            // Here, i is still incremented even though the if statement fails. 
            if (false & (++i < 100))
                Console.WriteLine("this won't be displayed");
            Console.WriteLine("if statement executed: " + i); // displays 1 

            // In this case, i is not incremented because the short-circuit 
            // operator skips the increment. 
            if (false && (++i < 100))
                Console.WriteLine("this won't be displayed");
            Console.WriteLine("if statement executed: " + i); // still 1 !! 
        }
    }
}
