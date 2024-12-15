using System;

public class EternalGoal : Goal
{
  // attribute? none needed

  public EternalGoal(string name, string description, int points) : base (name, description, points)
  {
  }

  public override void RecordEvent()
  {
    Console.WriteLine($"You recorded progress for the Eternal Goal: {_shortName}");
  }

  public override bool IsComplete()
  {
    return false; //eternal goals are never complete, a never ending goal
  }

  public override string GetStringRepresentation()
  {
    return $"SimpleGoal:{_shortName},{_description},{_points}";
  }

  public static EternalGoal FromString(string details)
  {
    var parts = details.Split(",");
    return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
    
  }
}