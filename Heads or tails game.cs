using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCoin
{
    class Program
    {
        static void Main(string[] args)
        {
            int coin;
            string userGuess;
            Random rng = new Random();

            // Query the user
            Console.Write("Enter your Guess Heads or Tails ");
            userGuess = Console.ReadLine();

            //Get a random number for the coin flip

            coin = rng.Next(0, 2);

            if (coin == 0 && userGuess == "T, t, Tails, tails")
            {
                Console.WriteLine("The coin flip is tails, you win!");
            }
            else if (coin == 1 && userGuess == "H")
            {
                Console.WriteLine("The coin flip is Heads, you win");
            }
            else
            {
                if (coin == 0)
                {
                    Console.WriteLine("The coin flip is tails, try again");
                }
                else
                {
                    Console.WriteLine("The coin flip is heads, try again");

                }
            }

            Console.ReadLine();
        }

     
    }
}
    

