using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    class Program
    {
        static void Main(string[] args)
        {

            Player p1 = new Player("John", 100.50);

            Croupier c1 = new Croupier("Best", 1000.00, 5);

            double bid = 50.00;

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Round no.{i}");

                int playerResult = p1.RollDice();
                Console.WriteLine($"Player {p1.Name} rolled: {playerResult}");
                int croupierResult = c1.RollDice();
                Console.WriteLine($"Croupier {c1.Name} rolled: {croupierResult}");

                if (playerResult == croupierResult)
                {
                    Console.WriteLine("Draw - no win");
                }
                else if (playerResult > croupierResult)
                {
                    Console.WriteLine($"Player {p1.Name} wins {bid}");
                    c1.Loose(p1, bid);


                }
                else
                {
                    Console.WriteLine($"Croupier {c1.Name} wins {bid}");
                    c1.Win(p1, bid);

                }

                Console.WriteLine($"Player {p1.Name} has {p1.Money}");
                Console.WriteLine($"Coupier {c1.Name} has {c1.Money}");

                Console.WriteLine();
            }
           
            Console.ReadLine();
        }
    }
}
