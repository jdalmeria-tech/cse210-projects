using System;

public class ChecklistGoal : Goal
{
  private int _amountCompleted;
  private int _target;
  private int _bonus;

  public ChecklistGoal(string name, string description, int points, int target, int bonus) : base (name, description, points)
  {
    _target = target;
    _bonus = bonus;
    _amountCompleted = 0;
  }

  public override void RecordEvent()
  {
    _amountCompleted++;

    if (IsComplete())
    {
      Console.WriteLine($"CONGRATS! You completed the Checklist Goal: {_shortName} and earned {_bonus} bonus points!");
    }
    else
    {
      Console.WriteLine($"Progress recorded for {_shortName}. Progress: {_amountCompleted}/{_target}");
    }
  }

  public override bool IsComplete()
  {
    return _amountCompleted >= _target; 
  }

  public override string GetDetailsString()
  {
    string status = IsComplete() ? "[X]" : "[ ]";
    return $"{status} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
  }

  public override string GetStringRepresentation()
  {
    return $"ChecklistGoal,{_shortName},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
  }

  public static ChecklistGoal FromString(string details)
  {
    var parts = details.Split(",");
    var goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
    goal._amountCompleted = int.Parse(parts[6]);
    return goal;
  
  }
}