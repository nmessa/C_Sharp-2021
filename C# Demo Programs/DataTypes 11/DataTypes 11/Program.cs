using System;

namespace DataTypes_11
{
    class ScopeDemo
    {
        static void Main()
        {
            int x; // known to all code within Main() 

            x = 10;
            if (x == 10)
            { // start new scope
                int y = 20; // known only to this block 

                // x and y both known here. 
                Console.WriteLine("x and y: " + x + " " + y);
                x = y * 2;
            }
            // y = 100; // Error! y not known here  

            // x is still known here. 
            Console.WriteLine("x is " + x);
        }
    }

}
