using System;

namespace Guess_3
{
    class Guess3
    {
        static void Main()
        {
            char ch, answer = 'K';

            Console.WriteLine("I'm thinking of a letter between A and Z.");
            Console.Write("Can you guess it: ");

            ch = (char)Console.Read(); // get the user's guess 

            if (ch == answer) Console.WriteLine("** Right **");
            else
            {
                Console.Write("...Sorry, you're ");

                // A nested if. 
                if (ch < answer) Console.WriteLine("too low");
                else Console.WriteLine("too high");
            }
        }
    }

}
