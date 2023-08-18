using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                for (int k = i; k < 10; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < i * 2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= 10; i++)
            {
                for (int j = i; j > 1; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 2*i-1 ; k <20 ;k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


        }
    }
}
