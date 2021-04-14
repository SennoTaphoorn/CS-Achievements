using System;

namespace Scopes
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i < 50)
                {
                    Console.WriteLine("Hond");
                }
                else
                {
                    Console.WriteLine("Kat");
                }
            }
            Console.ReadKey();
        }

    }
}
