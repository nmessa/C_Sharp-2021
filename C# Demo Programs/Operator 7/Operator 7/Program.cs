using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Operator_7
{
    class LtoD
    {
        static void Main()
        {
            long L;
            double D;

            D = 100123285.0;
            L = D; // Illegal!!! 

            Console.WriteLine("L and D: " + L + " " + D);
        }
    }

}
