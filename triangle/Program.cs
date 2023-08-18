using System;

namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 15;
            int count = 1;
            for (int i = 0; i < n/2; i++)
                Console.Write(" ");
            Console.WriteLine("*");
            for (int j = 1; j < (n / 2)-1 ; j++)
            {
                
                for (int i = j; i < (n/2); i++)
                    Console.Write(" ");
                Console.Write("*");
                for(int x=0;x<count;x++)
                    Console.Write(" ");
                Console.Write("*");
                count += 2;
                Console.WriteLine();
            }
            for(int i=0;i<n/2;i++)
                Console.Write(" *");
        }
    }
}
