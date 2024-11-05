using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";

        while (response == "yes")
        {
            Random randomGenerator = new Random();
            int magic = randomGenerator.Next(1, 100);
            int guess = 0;
            int count = 0;

            while (guess != magic)
            {
                Console.Write("What is your guess? (1-100): ");
                string valueFromUser = Console.ReadLine();
                guess = int.Parse(valueFromUser);
                count ++;

                if (magic > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magic < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }

            }
            // For the stretch challenge
            // Print the number of guesses
            Console.WriteLine($"You have guessed {count} time(s).");

            // Ask user if they want to play again
            Console.Write("Do you want to play again? (yes/no): ");
            response = Console.ReadLine().Trim().ToLower();
        }
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("Good Game, Well Played!");
    }
}