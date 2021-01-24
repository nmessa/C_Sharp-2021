using System;

namespace DataTypes_13
{
    class NestVar
    {
        static void Main()
        {
            int count;

            for (count = 0; count < 10; count = count + 1)
            {
                Console.WriteLine("This is count: " + count);

                // Illegal!!! This conflicts with the previous count. 
                //int count;

                //for (count = 0; count < 2; count++)
                    //Console.WriteLine("This program is in error!");
            }
        }
    }

}
