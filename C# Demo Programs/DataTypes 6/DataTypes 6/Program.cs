using System;

namespace DataTypes_6
{
    class Mars
    {
        static void Main()
        {
            double distance;
            double lightspeed;
            double delay;
            double delay_in_min;

            distance = 34000000; // 34,000,000 miles 
            lightspeed = 186000; // 186,000 miles per second 

            delay = distance / lightspeed;

            Console.WriteLine("Time delay when talking to Mars: " +
                              delay + " seconds.");

            delay_in_min = delay / 60;

            Console.WriteLine("This is " + delay_in_min +
                              " minutes.");
        }
    }
}
