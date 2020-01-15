using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 10);
            int guessesLeft = 3;
            bool guessed = false;
            // string userInput;

            while (guessesLeft > 0 && guessed == false) {
                Console.WriteLine("Guess the number:");
                // userInput = Console.ReadLine();
                // int userGuess = Convert.ToInt32(userInput);
                // Int32.TryParse(string userInput, out int userGuess);
                int userGuess = int.Parse(Console.ReadLine());

                if (userGuess == -1) {
                    return;
                }

                if (userGuess > randomNumber) {
                    Console.WriteLine("Correct number is lower than your guess.");
                    guessesLeft--;
                }
                else {
                    if (userGuess < randomNumber) {
                        Console.WriteLine("Correct number is higher than your guess.");
                        guessesLeft--;
                    }
                }
                if (userGuess == randomNumber) {
                    guessed = true;
                    Console.WriteLine("You have won!");
                }
            }
            if (guessed == false) {
                Console.WriteLine("You have lost.");
            }
        }
    }
}
