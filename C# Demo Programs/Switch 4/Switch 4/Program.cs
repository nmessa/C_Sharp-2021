using System;

namespace Switch_4
{
    class Help
    {
        static void Main()
        {
            char choice;

            Console.WriteLine("Help on:");
            Console.WriteLine("  1. if");
            Console.WriteLine("  2. switch");
            Console.Write("Choose one: ");
            choice = (char)Console.Read();

            Console.WriteLine("\n");

            switch (choice)
            {
                case '1':
                    Console.WriteLine("The if:\n");
                    Console.WriteLine("if(condition) statement;");
                    Console.WriteLine("else statement;");
                    break;
                case '2':
                    Console.WriteLine("The switch:\n");
                    Console.WriteLine("switch(expression) {");
                    Console.WriteLine("  case constant:");
                    Console.WriteLine("    statement sequence");
                    Console.WriteLine("    break;");
                    Console.WriteLine("  // ...");
                    Console.WriteLine("}");
                    break;
                default:
                    Console.Write("Selection not found.");
                    break;
            }
        }
    }
}
