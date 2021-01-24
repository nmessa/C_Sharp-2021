using System;

namespace TwoParameter
{
    class Factor
    {
        // Determine if x is a factor of y. 
        public bool isFactor(int x, int y)
        {
            if ((y % x) == 0) return true;
            else return false;
        }
    }

    class IsFact
    {
        static void Main()
        {
            Factor x = new Factor();

            if (x.isFactor(2, 20)) 
                Console.WriteLine("2 is factor");
            if (x.isFactor(3, 20)) 
                Console.WriteLine("3 is a factor");
        }
    }
}
