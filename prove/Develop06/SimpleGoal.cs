using System;

// references:
// https://byui-cse.github.io/cse210-ww-course/week06/prepare.html
// https://byui-cse.github.io/cse210-ww-course/week05/prepare.html
// https://www.w3schools.com/cs/cs_booleans.php
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/static

public class SimpleGoal : Goal
{
  private bool _isComplete;

  public SimpleGoal(string name, string description, int points) : base (name, description, points)
  {
    _isComplete = false;
  }

  public override void RecordEvent()
  {
    _isComplete = true;
  }

  public override bool IsComplete()
  {
    return _isComplete;
  }

  public override string GetDetailsString()
  {
    return _isComplete ? $"[X] {_shortName} ({_description})" : base.GetDetailsString();
  }

    public override string GetStringRepresentation()
  {
    return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
  }

  // a helper function designed to support file I/O operations
  // I decided to write the deserialization logic in each o the derived classes
  // so I can just call it on my GoalManager.cs instead of writing it again and again
  public static SimpleGoal FromString(string details)
  {
    var parts = details.Split(",");
    return new SimpleGoal(parts[0], parts[1], int.Parse(parts[2]))
    {
      _isComplete = bool.Parse(parts[3])
    };
  }
}