using System;

class Program
{
    static void Main(string[] args)
    {
        // initialize scripture verse
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string scriptureText = "Trust in the Lord with all your heart and lean not on your own understanding; in all thy ways acknowledge Him, and He shall direct thy paths.";
        Scripture scripture = new Scripture(reference, scriptureText);

        // display scripture until completely hidden or user quits
        while (!scripture.IsCompletelyHidden())
        {
            Scripture.ClearConsole();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");

            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        // display this when all words are hidden
        if (scripture.IsCompletelyHidden())
        {
            Scripture.ClearConsole();
            Console.WriteLine("The scripture is completely hidden (:");
            Console.WriteLine(scripture.GetDisplayText());
        }

        Console.WriteLine("\nProgram ended. Press any key to exit...");
        Console.ReadKey();


    }
}