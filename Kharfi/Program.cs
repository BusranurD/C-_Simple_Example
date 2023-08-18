using System;

namespace Kharfi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 8;
            for (int i = n; i >= 1; i--)
            {
                Console.Write("*");
                for (int j = 1; j < i ; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
            for (int i = n; i >= 1; i--)
            {
                Console.Write("*");
                for (int j = i; j < n ; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
        }
    }
}
