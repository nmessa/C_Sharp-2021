using System;

namespace Fundamentals_3
{
    class IntVsDouble
    {
        static void Main()
        {
            int ivar;    // this declares an int variable  
            double dvar; // this declares a floating-point variable  

            // Assign ivar the value 10.  
            ivar = 10;

            // Assign dvar the value 10.0.  
            dvar = 10.0;

            Console.WriteLine("Original value of ivar: " + ivar);
            Console.WriteLine("Original value of dvar: " + dvar);

            Console.WriteLine(); // print a blank line  

            // Now, divide both by 4.  
            ivar = ivar / 4;
            dvar = dvar / 4.0;

            Console.WriteLine("ivar after division: " + ivar);
            Console.WriteLine("dvar after division: " + dvar);
        }
    }
}
