using System;

namespace SimpleConstructor
{
    class MyClass
    {
        public int x;

        public MyClass()
        {
            x = 10;
        }
    }

    class ConsDemo
    {
        static void Main()
        {
            MyClass t1 = new MyClass();
            MyClass t2 = new MyClass();

            Console.WriteLine(t1.x + " " + t2.x);
        }
    }

}
