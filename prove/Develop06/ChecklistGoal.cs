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
  }

  public override void RecordEvent()
  {
    //needs to improve
  }

  public override bool IsComplete()
  {
    return true; //needs to improve
  }

  public override string GetDetailsString()
  {
    return ""; //needs to improve
  }

  public override string GetStringRepresentation()
  {
    return""; //needs to improve
  }
}