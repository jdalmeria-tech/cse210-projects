using System;
using System.Collections. Generic;
using System.IO;

public class GoalManager
{
  private List<Goal> _goals;
  private int _score;

  public GoalManager()
  {
    _score = 0;
  }

  public void Start()
  {
    bool running = true;

    while (running)
    {
      Console.WriteLine("\nMenu Options:");
      Console.WriteLine("   1. Create a New Goal");
      Console.WriteLine("   2. List Goals");
      Console.WriteLine("   3. Save Goals");
      Console.WriteLine("   4. Load Goals");
      Console.WriteLine("   5. Record Event");
      Console.WriteLine("   6. Quit");
      Console.Write("Select a choice from the menu: ");
      string choice = Console.ReadLine();

      switch (choice)
      {
        case "1":
            CreateGoal();
            break;

        case "2":
            ListGoalDetails();
            break;

        case "3":
            SaveGoals();
            break;

        case "4":
            LoadGoals();
            break;

        case "5":
            RecordEvent();
            break;

        case "6":
            running = false;
            break;

        default:
            Console.WriteLine("Invalid option. Choose from 1-6");
            break;
      }
    }
  }

  // this part next! (: one block of code at a time
  public void DisplayPlayerInfo()
  {
    //needs to improve Displays the players current score.
  }

  public void ListGoalNames()
  {
    //needs to improve Lists the names of each of the goals.
  }

  public void ListGoalDetails()
  {
    //needs to improve Lists the details of each goal (including the checkbox of whether it is complete).
  }

  public void CreateGoal()
  {
    // needs to improve Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
  }

  public void RecordEvent()
  {
    //needs to improve Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
  }

  public void SaveGoals()
  {
    //needs to improve Saves the list of goals to a file.
  }

  public void LoadGoals()
  {
    //needs to improve Loads the list of goals from a file.
  }

}