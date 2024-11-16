using System;

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
                    Console.Write("Enter the filename to save: ");
                    string saveFilename = Console.ReadLine();
                    theJournal.SaveToFile(saveFilename);
                    Console.WriteLine("Journal saved...");
                    break;

                case "5":
                    // quit the program
                    isRunningProgram = false;
                    Console.WriteLine("Thanks, write your journal entry again soon...");
                    break;
                
                default:
                    Console.WriteLine("Invalid choice. Please try again...");
                    break;
            }

        }
    }
}