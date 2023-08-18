using System;

namespace ilgincSayi
{
    class Program
    {
        static int faktoriyel(int sayi)
        {
            int faktoriyel = 1;
            for (int i = sayi; i > 0; i--)
            {
                faktoriyel *= i;
            }
            return faktoriyel;
        }

        static int kare(int sayi)
        {
            return sayi * sayi;
        }

        static void interestingNumber()
        {
            for (int i = 0; i <= 30; i++)
            {
                if (faktoriyel(i) < kare(i))
                {
                    Console.WriteLine(i);
                }
                else
                    continue;
            }
        }
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("enter number");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(faktoriyel(number));
            Console.WriteLine(kare(number));
            if(faktoriyel(number)<kare(number))
                Console.WriteLine("number is interesting number");
            else
                Console.WriteLine("number is not interesting number");

            interestingNumber();
        }
    }
}
