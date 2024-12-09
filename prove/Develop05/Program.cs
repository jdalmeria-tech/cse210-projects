using System;
using System.Collections.Generic;

// stretch challenge
// ensures program to run smoothly if user attempts to enter a string
// that is not convertible to an int (this can be found in the menu option)
// also added a feature to make sure that random prompts and questions are
// only used once (can be found in ReflectingActivity)

// references
// https://www.tutorialspoint.com/chash-int-tryparse-method
// https://learn.microsoft.com/en-us/dotnet/api/system.int32.tryparse?view=net-9.0
// https://josipmisko.com/posts/c-sharp-tryparse
// https://stackoverflow.com/questions/15294878/how-the-int-tryparse-actually-works
// https://stackoverflow.com/questions/19592084/why-do-all-tryparse-overloads-have-an-out-parameter
// https://www.reddit.com/r/csharp/comments/so6pvp/understanding_the_out_parameter/
// https://thedotnetguide.com/int32-tryparse-method-in-csharp/
// https://www.c-sharpcorner.com/article/out-parameters-in-c-sharp-7-0/
// https://www.educative.io/answers/what-is-parse-and-tryparse-in-c-sharp-10

class Program
{
    static void Main(string[] args)
    {
        // initialize
        bool running = true;

        while (running)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start Breathing Activity");
            Console.WriteLine(" 2. Start Listing Activity");
            Console.WriteLine(" 3. Start Reflecting Activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("\nSelect a choice from the menu: ");

            string userInput = Console.ReadLine();
            int choice;

            // this attempts to convert the userInput string into an integer
            // this handles an exception gracefully if user attempts to enter a string like "haha"
            // or any string that is not convertible to an int
            if (int.TryParse(userInput, out choice) && choice >= 1 && choice <=4)
            {
                switch (choice)
                {
                    case 1:
                        BreathingActivity breathingActivity = new BreathingActivity();
                        breathingActivity.RunTheActivity();
                    break;
                
                    case 2:
                        ListingActivity listingActivity = new ListingActivity();
                        listingActivity.RunTheActivity();
                        break;

                    case 3:
                        ReflectingActivity reflectingActivity = new ReflectingActivity();
                        reflectingActivity.RunTheActivity();
                        break;

                    case 4:
                        Console.WriteLine("Thank you! Hope to see you again soon (:");
                        running = false;
                        break;
                }
        
            }
            else
            {
                Console.WriteLine("Invalid input :( Please enter a number between 1 and 4.\n");
            }
        }

    }
}