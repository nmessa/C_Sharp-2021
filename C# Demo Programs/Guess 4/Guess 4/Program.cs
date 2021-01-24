using System;

namespace Guess_4
{
    class Guess4
    {
        static void Main()
        {
            char ch, answer = 'K';

            do
            {
                Console.WriteLine("I'm thinking of a letter between A and Z.");
                Console.Write("Can you guess it: ");

                // Read a letter, but skip cr/lf. 
                do
                {
                    ch = (char)Console.Read();
                } while (ch == '\n' | ch == '\r');

                if (ch == answer) Console.WriteLine("** Right **");
                else
                {
                    Console.Write("...Sorry, you're ");
                    if (ch < answer) Console.WriteLine("too low");
                    else Console.WriteLine("too high");
                    Console.WriteLine("Try again!\n");
                }
            } while (answer != ch);
        }
    }
}
