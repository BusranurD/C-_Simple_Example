using System;
using System.Reflection.Metadata.Ecma335;

namespace WordGame
{

    class Program
    {
        static void Main(string[] args)
        {
            string player1 = "";
            string player2 = "";
            char c = 'y';
            Random random = new Random();
            char beginning;
            beginning = Convert.ToChar(random.Next(97, 122));
          
            
            do
            {
                Console.WriteLine("start with " + beginning);
                Console.Write(" enter word player1 -> ");
                player1 = Console.ReadLine();
                if (player1[0] != beginning)
                {
                    Console.WriteLine("player1 : Game Over");
                    Console.WriteLine("restart? ( Y / N )");
                    c = Convert.ToChar(Console.ReadLine());
                    if (c != 'y' || c != 'Y')
                        continue;
                }
                do
                {
                    Console.Write("enter word player2 -> ");
                    player2 = Console.ReadLine();
                    if (player2[0] != player1[player1.Length - 1])
                    {
                        Console.WriteLine("player2 : Game Over");
                        beginning = player1[player1.Length - 1];
                        break;
                    }

                    Console.Write("enter word player1 -> ");
                    player1 = Console.ReadLine();
                    if (player1[0] != player2[player2.Length - 1])
                    {
                        Console.WriteLine("player1 : Game Over");
                        beginning = player2[player2.Length - 1];
                        break;
                    }

                } while (true);

                Console.WriteLine("restart? ( Y / N )");
                c = Convert.ToChar(Console.ReadLine());
            } while (c == 'y' || c == 'Y');

        }
    }
}
