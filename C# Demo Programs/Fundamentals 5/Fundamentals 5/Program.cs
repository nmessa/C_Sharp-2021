using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fundamentals_5
{
    class IfDemo
    {
        static void Main()
        {
            int a, b, c;

            a = 2;
            b = 3;

            // This if statement succeeds because a is less than b. 
            if (a < b) Console.WriteLine("a is less than b");

            // This won't display anything becase a does not equal b. 
            if (a == b) Console.WriteLine("you won't see this");

            // This if succeeds because a contains the value 2. 
            if (a == 2) Console.WriteLine("a contains the value 2");

            // This if fails because a does not contain the value 19. 
            if (a == 19) Console.WriteLine("you won't see this");

            // This if will succeed because a will be equal to b - 1. 
            if (a == b - 1) Console.WriteLine("a equals b - 1");

            Console.WriteLine();

            c = a - b; // c contains -1 

            Console.WriteLine("c contains -1");
            if (c >= 0) Console.WriteLine("c is non-negative");
            if (c < 0) Console.WriteLine("c is negative");

            Console.WriteLine();

            c = b - a; // c now contains 1 

            Console.WriteLine("c now contains 1");
            if (c >= 0) Console.WriteLine("c is non-negative");
            if (c < 0) Console.WriteLine("c is negative");

            Console.WriteLine();
        }
    }
}
