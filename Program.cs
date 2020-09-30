using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome Message
            Console.WriteLine("Welcome to the Higher Or Lower Game!");


            // Create a random number
            Random rng = new Random();
            int number = rng.Next(0, 14);

            //Attempted Guess
            Console.WriteLine("Please guess");
            int atempts = 0;

            while (true)
            {
                int Guess = Convert.ToInt32(Console.ReadLine());

                atempts = atempts + 1;

            //If command inside of a while command

           
                if (Guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (Guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Correct That is the number");
                    Console.WriteLine(atempts + " Number of attempts");
                    break;
                }
            }
            
            //wait for key press
            Console.ReadKey();

            //setup List of higher or lower
            List<string> Cards = new List<string>() { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };
            Random rng2 = new Random();
            int CardNumber = rng2.Next(0, 14);
            Console.WriteLine()
        }
    }
}
