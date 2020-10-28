using System;

namespace NetCore.Docker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Please, input your first and middle name (example: Renat Maratovich):");
            string name = Console.ReadLine();
            Console.WriteLine(" Hello, dear interviewee {0}!", name);
            Console.WriteLine("\n Please, input my first and last name (example: Renat Shakirov):");
            string myName = Console.ReadLine();

            if (myName.Equals("Renat Shakirov"))
            {
                Console.WriteLine(" \n                This is my GitHub:\n   https://github.com/Kusanagi-2029?tab=repositories");
            }
            else
            {
                Console.WriteLine("\n Please, input MY first and last name. EXAMPLE: \nRenat Shakirov\n :");
                string myName2 = Console.ReadLine();

                if (myName2.Equals("Renat Shakirov"))
                {
                    Console.WriteLine(" \n                This is my GitHub:\n   https://github.com/Kusanagi-2029?tab=repositories");
                }
                else
                {
                    Console.WriteLine("\n Oh, Blin :(    here's an EXAMPLE: \nRenat Shakirov\n");
                    string myName3 = Console.ReadLine();
                    Console.WriteLine(" \n     -____-    okay, here is my   GitHub:\n  https://github.com/Kusanagi-2029?tab=repositories");
                }
            }
        }
    }
}
