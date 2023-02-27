using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_01_CycleRace
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many players do you want: ");

            int amountPlayers = Convert.ToInt32(Console.ReadLine());

            string[] playerNames = new string[amountPlayers];

            for(int i = 0 ; i < amountPlayers; i++)
            {
                Console.Write($"Who is player {i + 1}? ");
                playerNames[i] = Console.ReadLine();
            }

            Console.Write("Ready? ");

            for (int i = 0; i < playerNames.Length; i++)
            {

                Console.Write($"{playerNames[i]}");

                if(i == playerNames.Length - 2)
                {
                    Console.Write(" and ");
                }
                else if(i < playerNames.Length - 2)
                {
                    Console.Write(", ");
                }

            }

            Console.ReadLine();



        }
    }
}
