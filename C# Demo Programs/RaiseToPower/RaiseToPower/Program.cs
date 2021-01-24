using System;

namespace RaiseToPower
{
    class Pwr
    {
        public double b;
        public int e;
        public double val;

        //constructor
        public Pwr(double num, int exp)
        {
            b = num;
            e = exp;

            val = 1;
            for (; exp > 0; exp--) 
                val = val * b;
        }

        public double getPwr()
        {
            return val;
        }
    }

    class DemoPwr
    {
        static void Main()
        {
            Pwr x = new Pwr(4.0, 2);
            Pwr y = new Pwr(2.5, 1);
            Pwr z = new Pwr(5.7, 0);

            Console.WriteLine(x.b + " raised to the " + x.e +
                               " power is " + x.getPwr());
            Console.WriteLine(y.b + " raised to the " + y.e +
                               " power is " + y.getPwr());
            Console.WriteLine(z.b + " raised to the " + z.e +
                               " power is " + z.getPwr());
        }
    }
}
