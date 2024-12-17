using System;
using System.Collections. Generic;
using System.Formats.Asn1;
using System.IO;

// resources:
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/using-indexers
// https://www.geeksforgeeks.org/c-sharp-list-class/
// https://www.youtube.com/watch?v=ToKbMa3xvMs
// https://www.youtube.com/watch?v=nYCMW3kfTvs
// https://www.w3schools.com/cs/cs_exceptions.php
// https://www.youtube.com/watch?v=EvSyka9vJho&t=37s
// https://www.youtube.com/watch?v=3SpYrojvRjs&list=PLI8-hwpdo-LajI3oeQFs7fPoaWve82ea9
// https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.clear?view=net-9.0
public class GoalManager
{
  private List<Goal> _goals;
  private int _score;

  public GoalManager()
  {
    _goals = new List<Goal>();
    _score = 0;
  }

  public void Start()
  {
    bool running = true;

    while (running)
    {
      Console.WriteLine($"\nYou have {_score} points.\n");
      Console.WriteLine("Menu Options:");
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
            Console.WriteLine("Thank you, looking forward to hearing from you again! (:");
            break;

        default:
            Console.WriteLine("Invalid option. Choose between 1-6");
            break;
      }
    }
  }

  
  public void DisplayPlayerInfo()
  {
    Console.WriteLine($"You have {_score} points.");
  }

  // public void ListGoalNames()
  // {
  //   for (int i = 0; i < _goals.Count; i ++)
  //   {
  //     Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
  //   }
  // }
  // not sure if I still need this

  public void ListGoalDetails()
  {
    if (_goals.Count == 0)
    {
      Console.WriteLine("No goals have been created yet.");
    }
    else
    {
      Console.WriteLine("The goals are:");
      for (int i = 0; i <_goals.Count; i++)
      {
        Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
      }
    }
  }

  public void CreateGoal()
  {
    Console.WriteLine("\nThe types of Goals are:");
    Console.WriteLine("   1. Simple Goal");
    Console.WriteLine("   2. Eternal Goal");
    Console.WriteLine("   3. Checklist Goal");
    Console.Write("Which type of goal would you like to create? ");
    string choice = Console.ReadLine();

    Console.Write("Enter the name of the goal: ");
    string name = Console.ReadLine();

    Console.Write("What is a short description of it? ");
    string description = Console.ReadLine();

    Console.Write("What is the amount of points associated with this goal? ");
    int points = int.Parse(Console.ReadLine());

    switch (choice)
    {
      case "1":
          _goals.Add(new SimpleGoal(name, description, points));
          break;

      case "2":
          _goals.Add(new EternalGoal(name, description, points));
          break;
      
      case "3":
          Console.Write("How many times does this goal need to be accomplished for a bonus? ");
          int target = int.Parse(Console.ReadLine());

          Console.Write("What is the bonus for accomplishing it that many times? ");
          int bonus = int.Parse(Console.ReadLine());

          _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
          break;
      
      default:
        Console.Write("Invalid option. Goal not created, please choose from 1-3");
        break;
    }
  }

  // asks the user which goal they have done and then records
  // the event by calling the RecordEvent method on that goal
  public void RecordEvent()
  {
    ListGoalDetails();
    if (_goals.Count > 0)
    {
      Console.Write("Which goal did you complete? Enter the number: ");
      int choice = int.Parse(Console.ReadLine()) - 1;

      if (choice >= 0 && choice < _goals.Count)
      {
        Goal goal = _goals[choice];
        goal.RecordEvent();
        _score += goal.GetPoints();
        if (goal.IsComplete())
        {
          Console.WriteLine($"You completed the goal: {goal.GetDetailsString()}");
        }
      }
      else
      {
        Console.WriteLine("Invalid option.");
      }
    }
  }

  // Saves the list of goals to a file.
  public void SaveGoals()
  {
    Console.Write("Enter the filename to save your goals: ");
    string filename = Console.ReadLine();

    using (StreamWriter writer = new StreamWriter(filename))
    {
      
      // this saves the score
      writer.WriteLine(_score);
      
      // save each goal's string representation
      foreach (Goal goal in _goals)
      {
        writer.WriteLine(goal.GetStringRepresentation());
      }
    }

    Console.WriteLine("Goals and score saved successfully!");
  }

  // Loads the list of goals from a file.
  public void LoadGoals()
  {
    Console.Write("Enter the filename to load the goals from: ");
    string filename = Console.ReadLine();

    if (File.Exists(filename))
    {
      string [] lines = File.ReadAllLines(filename);

      // read the first line as the score

      _score = int.Parse(lines[0]);

      // clear existing goals and load from file
      _goals.Clear();
      for (int i = 1; i < lines.Length; i++) // start at index 1 to skip the score
      {
        string line = lines[i];
        string[] parts = line.Split(":");
        string goalType = parts[0];
        string[] goalDetails = parts[1].Split(",");

        switch (goalType)
        {
          case "SimpleGoal":
            _goals.Add(SimpleGoal.FromString(string.Join(",", goalDetails)));
            break;

          case "EternalGoal":
            _goals.Add(EternalGoal.FromString(string.Join(",", goalDetails)));
            break;

          case "ChecklistGoal":
            _goals.Add(ChecklistGoal.FromString(string.Join(",", goalDetails)));
            break;

        }
      }

      Console.WriteLine("Goals and score loaded successfully");
      
    }
    else
    {
      Console.WriteLine("File not found :(");
    }
  }

}