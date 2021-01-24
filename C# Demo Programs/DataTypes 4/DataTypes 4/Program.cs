using System;

namespace DataTypes_4
{
    class UseDecimal
    {
        static void Main()
        {
            decimal balance;
            decimal rate;

            // Compute new balance. 
            balance = 1000.10m;
            rate = 0.1m;
            balance = balance * rate + balance;

            Console.WriteLine("New balance: $" + balance);
        }
    }

}
