using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            bool realInteger = false;
            int randomNumber = rand.Next(20) + 1;
            int userNumberGuess = 0;
            bool correctGuess = false;

            Console.WriteLine("Hello and welcome to our Number Guessing Game, YAY!!");
            Console.WriteLine("Our A.I> has chosen a number btw 1 and 20");
            while (correctGuess == false)
            {
                Console.WriteLine("Can you guess the number our A.I. chose?");
                string input = Console.ReadLine();
                userNumberGuess = int.Parse(input);
                realInteger = int.TryParse(input, out userNumberGuess);

                if ((userNumberGuess > 20) || (userNumberGuess < 1) || (realInteger == false))
                {
                    Console.WriteLine("You did not enter a number between 1 and 20");
                }
                Console.WriteLine($"You Chose {userNumberGuess}...");
                //Console.WriteLine($"The AI chose {randomNumber}.");

                if (userNumberGuess > randomNumber)
                {
                    Console.WriteLine("but that quess was too high");
                }
                else if (userNumberGuess < randomNumber)
                {
                    Console.WriteLine("that guess is too low");
                }
                else if (userNumberGuess == randomNumber)
                {
                    Console.WriteLine("You got it");
                    correctGuess = true;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Press 'Enter' to quit.");
            Console.ReadLine();
        }
    }
}
