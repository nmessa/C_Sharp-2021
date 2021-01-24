using System;

namespace Guess_1
{
    class Guess
    {
        static void Main()
        {
            char ch, answer = 'K';

            Console.WriteLine("I'm thinking of a letter between A and Z.");
            Console.Write("Can you guess it: ");

            ch = (char)Console.Read(); // get the user's guess 

            if (ch == answer) Console.WriteLine("** Right **");
        }
    }
}
