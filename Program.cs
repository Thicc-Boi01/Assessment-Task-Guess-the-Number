using System;
using System.Collections.Generic;

namespace GuessNum
{
    class Program
    {
        static void Main(string[] args)

        {
            int guessno;
            int guessres;
            guessno = 0;
            int guessrem;
            guessrem = 7;


            List<int> Guessed = new List<int>();

            //Random number generator
            Random r = new Random();
            int genRand = r.Next(0, 25);
            // Console.WriteLine("Random Number = " + genRand);

            Console.WriteLine("Hey there! Lets play a little guessing game.");
            Console.WriteLine("Guesse the number between 0 and 25");

            //If you still have chances
            while (guessno < 7)
            {

                Console.WriteLine("Enter Guess:");

                guessres = int.Parse(Console.ReadLine());
                Guessed.Add(guessres);
                guessno++;

                //if correct
                if (guessres == genRand)
                {
                    Console.WriteLine("Damn. You win!");
                    Console.WriteLine("The Number Was Indeed " + genRand);
                    Console.WriteLine("You guessed the number in " + guessno + " guesses !");
                    Console.WriteLine("Your guess log:");
                    foreach (int i in Guessed)
                    {
                        Console.Write(i + ",");
                    }
                    Environment.Exit(0);

                }
                else
                {
                    guessrem--;
                    if (guessres < genRand)
                    {
                        Console.WriteLine("Nope its MORE then that!");
                    }
                    if (guessres > genRand)
                    {
                        Console.WriteLine("Nope its LESS then that!");
                    }

                    Console.WriteLine("You have " + guessrem + " Guesses Remaining!");

                }

            }
            Console.WriteLine("Sage YOU LOOSE!");
            Console.WriteLine("The number was " + genRand + " you FOOL!");
            Console.WriteLine("Your guess log:");
            foreach (int i in Guessed)
            {
                Console.Write(i + ",");
            }

        }
    }
}
