using System;
using System.Runtime.InteropServices;

namespace busra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("* * * * *");
            for (int i = 0; i < 2; i++)
                Console.WriteLine("*       *");
            Console.WriteLine("* * * * *");
            for (int i = 0; i < 2; i++)
                Console.WriteLine("*       *");
            Console.WriteLine("* * * * *");
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
                Console.WriteLine("*       *");
            Console.WriteLine("* * * * *");
            Console.WriteLine();
            Console.WriteLine("* * * * *");
            for (int i = 0; i < 2; i++)
                Console.WriteLine("*        ");
            Console.WriteLine("* * * * *");
            for (int i = 0; i < 2; i++)
                Console.WriteLine("        *");
            Console.WriteLine("* * * * *");
            Console.WriteLine();
            Console.WriteLine("* * * * *");
            for (int i = 0; i < 2; i++)
                Console.WriteLine("*       *");
            Console.WriteLine("* * * * *");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("* ");
                for(int j=0 ; j<i;j++)
                    Console.Write("  ");
                Console.Write(" *");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("* * * * *");
            for (int i = 0; i < 2; i++)
                Console.WriteLine("*       *");
            Console.WriteLine("* * * * *");
            for (int i = 0; i < 2; i++)
                Console.WriteLine("*       *");
        }
    }
}
