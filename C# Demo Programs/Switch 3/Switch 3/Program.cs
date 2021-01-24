using System;

namespace Switch_3
{
    class VowelsAndConsonants
    {
        static void Main()
        {
            char ch;

            Console.Write("Enter a letter: ");
            ch = (char)Console.Read();
            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'y':
                    Console.WriteLine("Letter is a vowel.");
                    break;
                default:
                    Console.WriteLine("Letter is a consonant.");
                    break;
            }
        }
    }
}
