using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start Breathing Activity");
            Console.WriteLine(" 2. Start Listing Activity");
            Console.WriteLine(" 3. Start Reflecting Activity");
            Console.WriteLine(" 4. Quit");

            Console.Write("\nSelect a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 4)
            {
                Console.WriteLine("Thank you. Hope to see you again soon (:");
                break; // this ends the program
            }

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

                default:
                    Console.WriteLine("Invalid choice :( Please pick a number 1 to 4.");
                    break;
            }
        }
    }
}