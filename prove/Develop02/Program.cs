using System;

// the stretch challenge that I did:
// my journal program can handle both csv and txt files
// handle meaning, load and save files
// also handled possible errors like; what if user tries to save a file and enters a blankspace or whitespace,
// what if user loads an incorrect format or a file that doesn't exist
// what if user asks to display even if there is no entry
// I have handled these possible errors to keep my program running
// also added a few methods to handle special characters like commas and quotes in my Journal.cs
// please feel free to check the other methods that I have not mentioned here, I made a comment
// on my Journal.cs so the checker can understand what that method does
// thanks for taking the time to check my project for week02 (:

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool isRunningProgram = true;

        Console.WriteLine("Welcome to My Journal Program!");

        while (isRunningProgram)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine(" 1. Write");
            Console.WriteLine(" 2. Display");
            Console.WriteLine(" 3. Load");
            Console.WriteLine(" 4. Save");
            Console.WriteLine(" 5. Quit");
            Console.Write("What would you like to do? (pick a number): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // ask user to write a new entry
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("> ");
                    string response = Console.ReadLine();
                    theJournal.AddEntry(new Entry(DateTime.Now, prompt, response));
                    Console.WriteLine("Entry saved..."); // added this so user knows that entry is saved
                    break;
                
                case "2":
                    // display the journal
                    if (theJournal._entries.Count > 0)
                    {
                        theJournal.DisplayAll();
                    }
                    else
                    {
                        Console.WriteLine("No entries to display");
                    }
                    break;

                case "3":
                    // load the file
                    Console.Write("Enter the filename to load: ");
                    string loadFilename = Console.ReadLine();
                    theJournal.LoadFromFile(loadFilename);
                    break;
                
                case "4":
                    // save the journal to file
                    // this also catches if the user tries to save a file and enters a blank space.
                    string filename = "";
                    do
                    {
                     Console.Write("Enter the filename to save (e.g., journal.csv or journal.txt): ");
                     filename = Console.ReadLine();

                     if (string.IsNullOrWhiteSpace(filename))
                     {
                        Console.WriteLine("Filename can't be empty or only whitespace. Please try again.");
                     }
                    } while (string.IsNullOrWhiteSpace(filename));

                    theJournal.SaveToFile(filename);
                    break;

                case "5":
                    // quit the program
                    isRunningProgram = false;
                    Console.WriteLine("Thank you! Remember to record your experiences again (:");
                    break;
                
                default:
                    Console.WriteLine("Invalid choice. Please try again...");
                    break;
            }

        }
    }
}