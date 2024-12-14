using System;

public class SimpleGoal : Goal
{
  private bool _isComplete;

  public SimpleGoal(string name, string description, int points) : base (name, description, points)
  {
  }

  public override void RecordEvent()
  {
    //needs to improve
  }

  public override bool IsComplete()
  {
    return true; //needs to improve
  }

  public override string GetStringRepresentation()
  {
    return""; //needs to improve
  }
}