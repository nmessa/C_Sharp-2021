using System;

namespace UseParameter
{
    // This class contains the method isEven that takes a parameter. 
    class ChkNum
    {
        // Return true if x is even. 
        public bool isEven(int x)
        {
            if ((x % 2) == 0) 
                return true;
            else 
                return false;
        }
    }

    class ParmDemo
    {
        static void Main()
        {
            ChkNum e = new ChkNum();
            if (e.isEven(10)) 
                Console.WriteLine("10 is even.");

            if (e.isEven(9)) 
                Console.WriteLine("9 is even.");

            if (e.isEven(8))
                Console.WriteLine("8 is even.");
        }
    }

}
