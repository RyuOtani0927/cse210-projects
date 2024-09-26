using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        Console.WriteLine("Welcome to Guess My Number!");

        Console.WriteLine();

        string continueGame = "yes";

        while (continueGame == "yes")
        {
            Random randomGenerator = new Random();
            int magicNum = randomGenerator.Next(1, 100);

            int guess = -1;

            int guessNum = 0;

            while (guess != magicNum)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();
                guess = int.Parse(input);

                guessNum = guessNum + 1;

                if (magicNum > guess)
                {
                    Console.WriteLine("Higher");
                } 
                else if (magicNum < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");

                    Console.WriteLine();

                    Console.WriteLine($"{guessNum} guesses made!");

                    Console.WriteLine();

                    Console.Write("Do you want to play again? (yes/no) ");
                    continueGame = Console.ReadLine().ToLower();

                    Console.WriteLine();
                }
                
            }
        
        }

        Console.WriteLine("Thank you for playing the game!");

        Console.WriteLine();

    }
}