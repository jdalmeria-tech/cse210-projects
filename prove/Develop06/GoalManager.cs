using System;
using System.Collections. Generic;
using System.IO;

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
      Console.WriteLine($"You have {_score} points.");
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
            Console.WriteLine("Thank you, looking forward to hearing from you again! (:");
            break;

        default:
            Console.WriteLine("Invalid option. Choose from 1-6");
            break;
      }
    }
  }

  
  public void DisplayPlayerInfo()
  {
    Console.WriteLine($"You have {_score} points.");
  }

  public void ListGoalNames()
  {
    for (int i = 0; i < _goals.Count; i ++)
    {
      Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
    }
  }

  public void ListGoalDetails()
  {
    foreach (var goal in _goals)
    {
      Console.WriteLine(goal.GetDetailsString());
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
    ListGoalNames();
    Console.Write("Which goal did you complete? Enter the number: ");
    int choice = int.Parse(Console.ReadLine()) - 1; // remember that lists starts with 0

    if (choice >= 0 && choice < _goals.Count)
    {
      _goals[choice].RecordEvent();
      _score += _goals[choice].GetPoints();
    }
    else
    {
      Console.WriteLine("Invalid option.");
    }
  }

  // Saves the list of goals to a file.
  public void SaveGoals()
  {
    Console.Write("Enter the filename to save your goals: ");
    string filename = Console.ReadLine();

    using (StreamWriter outputFile = new StreamWriter(filename))
    {
      foreach (var goal in _goals)
      {
        outputFile.WriteLine(goal.GetStringRepresentation());
      }
    }

    Console.WriteLine("Goals saved successfully!");
  }

  // Loads the list of goals from a file.
  public void LoadGoals()
  {
    Console.Write("Enter the filename to load the goals from: ");
    string filename = Console.ReadLine();

    if (File.Exists(filename))
    {
      string [] lines = File.ReadAllLines(filename);
      _goals.Clear();

      foreach (string line in lines)
      {
        string[] parts = line.Split(":");
        string goalType = parts[0];
        string details = parts[1];

        switch (goalType)
        {
          case "SimpleGoal":
            _goals.Add(SimpleGoal.FromString(details));
            break;
          
          case "EternalGoal":
            _goals.Add(EternalGoal.FromString(details));
            break;
          
          case "ChecklistGoal":
            _goals.Add(ChecklistGoal.FromString(details));
            break;
        }
      }

      Console.WriteLine("Goals loaded successfully!");
    }
    else
    {
      Console.WriteLine("File not found :(");
    }

  }

}