using System;

namespace Operator_9
{
    class PromDemo
    {
        static void Main()
        {
            byte b;
            int i;

            b = 10;
            i = b * b; // OK, no cast needed 

            b = 10;
            b = (byte)(b * b); // cast needed!! 

            Console.WriteLine("i and b: " + i + " " + b);
        }
    }
}
