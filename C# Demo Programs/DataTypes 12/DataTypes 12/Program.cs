using System;

namespace DataTypes_12
{
    class VarInitDemo
    {
        static void Main()
        {
            int x;

            for (x = 0; x < 3; x++)
            {
                int y = -1; // y is initialized each time block is entered 
                Console.WriteLine("y is: " + y); // this always prints -1 
                y = 100;
                Console.WriteLine("y is now: " + y);
            }
        }
    }

}
