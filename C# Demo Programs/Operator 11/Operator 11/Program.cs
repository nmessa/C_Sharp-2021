using System;

namespace Operator_11
{
    class RegPay
    {
        static void Main()
        {
            decimal Principal;    // original principal 
            decimal IntRate;      // interest rate as a decimal, such as 0.075 
            decimal PayPerYear;   // number of payments per year 
            decimal NumYears;     // number of years 
            decimal Payment;      // the regular payment 
            decimal numer, denom; // temporary work variables 
            double b, e;          // base and exponent for call to Pow() 

            Principal = 10000.00m;
            IntRate = 0.075m;
            PayPerYear = 12.0m;
            NumYears = 5.0m;

            numer = IntRate * Principal / PayPerYear;

            e = (double)-(PayPerYear * NumYears);
            b = (double)(IntRate / PayPerYear) + 1;

            denom = 1 - (decimal)Math.Pow(b, e);

            Payment = numer / denom;

            Console.WriteLine("Payment is {0:C}", Payment);
        }
    }
}
