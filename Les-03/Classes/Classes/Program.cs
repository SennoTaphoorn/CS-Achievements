using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = Add(9, 10);
            Console.WriteLine(i);
            int m = Mult(9, 10);
            Console.WriteLine(m);
        }
        static int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }
        static int Mult(int a, int b)
        {
            int d = a * b;
            return d;
        }
    }
}
