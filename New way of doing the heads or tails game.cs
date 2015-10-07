using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWayCoinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            int coin;
            string userGuess;
            string coinDescription = "T";
            Random rng = new Random();

            //Query the user for heads or tails

            Console.Write("Enter your guess H or T ");
            userGuess = Console.ReadLine();

            //get a random number for the coin flip

            coin = rng.Next(0, 2);
            if (coin == 1)
            {
                coinDescription = "H";

            }
            if ((coin == 0 && userGuess == "T") || (coin == 1 && userGuess == "H"))
            {
                Console.WriteLine("The coin flip was {0}, you win", coinDescription);
            }
            else
            {
                Console.WriteLine("Coin flip is {0}, you lose", coinDescription);
            }

            Console.ReadLine();
        }
        
    }
}
