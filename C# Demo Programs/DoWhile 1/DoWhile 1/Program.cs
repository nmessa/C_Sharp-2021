using System;

namespace DoWhile_1
{
    class DWDemo
    {
        static void Main()
        {
            char ch;

            do
            {
                Console.WriteLine("Press a key following by ENTER: ");
                ch = (char)Console.Read(); // read a keypress 
            } while (ch != 'q');
        }
    }
}
