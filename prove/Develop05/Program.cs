using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   
        // make a list for the activities
        List<Activity> activities = new List<Activity>
        {
            new BreathingActivity(),
            new ListingActivity(),
            new ReflectingActivity()
        };

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness App! (:");
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Breathing Activity");
            Console.WriteLine(" 2. Listing Activity");
            Console.WriteLine(" 3. Reflecting Activity");
            Console.WriteLine(" 4. Quit");

            Console.Write("Select a choice from the menu (1-4)): ");
            string choice = Console.ReadLine();

            if (choice == "4")
            {
                Console.WriteLine("Thank you for using the Mindfulness App! Until next time (:");
                break; // this will exit the program (quit)
            }

            // validate the choice and execute the activity
            int activityIndex;
            if (int.TryParse(choice, out activityIndex) && activityIndex >= 1 && activityIndex <= 3)
            {
                Activity selectedActivity = activities[activityIndex - 1];
                Console.Clear();
                selectedActivity.RunTheActivity();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4."); // this makes sure that user enters 1 to 4
                Thread.Sleep(2000);
            }
        }
    }
}