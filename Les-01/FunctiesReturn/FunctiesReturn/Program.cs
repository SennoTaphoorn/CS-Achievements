using System;

namespace FunctiesReturn
{
    class Program
    {
        static int Name(int x, int y)
        {
            return x / y;
        }

        static void Main(string[] args)
        {
            int z = Name(9, 3);
            Console.WriteLine(z);
        }

    }
}
