using System;

namespace Keyboard
{
    class KbIn
    {
        static void Main()
        {
            char ch;

            Console.Write("Press a key followed by ENTER: ");

            // Read a key from the keyboard. 
            ch = (char)Console.Read();

            Console.WriteLine("Your key is: " + ch);
        }
    }
}
