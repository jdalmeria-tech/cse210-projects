using System;
// thanks for taking the time to review my project
// stretch challenge that I did for this part is to display two scripture references
// while maintaining the same principles from the previous version
// also as stated on the Functional Requirements "As a stretch challenge, try to randomly
// select from only those words that are not already hidden." - I included this on the program
// I left notes at the top of each class for the references that helped me as I write the program (:
class Program
{
    static void Main(string[] args)
    {
        // initialize scripture verses
        Reference reference1 = new Reference("Proverbs", 3, 5, 6);
        string scriptureText1 = "Trust in the Lord with all your heart and lean not on your own understanding; in all thy ways acknowledge Him, and He shall direct thy paths.";
        Scripture scripture1 = new Scripture(reference1, scriptureText1);

        Reference reference2 = new Reference("1 John", 4, 8);
        string scriptureText2 = "He that loveth not knoweth not God; for God is love.";
        Scripture scripture2 = new Scripture(reference2, scriptureText2);

        // display scripture until completely hidden or user quits
        while (!scripture1.IsCompletelyHidden() || !scripture2.IsCompletelyHidden())
        {
            Scripture.ClearConsole();

            // display 1st scripture verse
            Console.WriteLine(scripture1.GetDisplayText());
            Console.WriteLine();

            // display 2nd scripture verse
            Console.WriteLine(scripture2.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");

            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                break;
            }

            // hide words in both scripture references
            if (!scripture1.IsCompletelyHidden())
            {
                scripture1.HideRandomWords(3);
            }
            if (!scripture2.IsCompletelyHidden())
            {
                scripture2.HideRandomWords(3);
            }
        }

        // display this when all words are hidden
        Scripture.ClearConsole();
        Console.WriteLine("Both scripture references are completely hidden (:");
        Console.WriteLine("\nProgram ended. Press any key to exit...");
        Console.ReadKey();


    }
}