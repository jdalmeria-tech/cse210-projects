using System;

// resources:
// https://byui-cse.github.io/cse210-ww-course/week05/prepare.html
// https://byui-cse.github.io/cse210-ww-course/week06/prepare.html

public abstract class Goal
{
  protected string _shortName;
  protected string _description;
  protected int _points;

  public Goal(string name, string description, int points)
  {
    _shortName = name;
    _description = description;
    _points = points;
  }

  public int GetPoints()
  {
    return _points;
  }

  public abstract void RecordEvent();

  public abstract bool IsComplete();

  public virtual string GetDetailsString()
  {
    return $"[ ] {_shortName} ({_description})";
  }

  public abstract string GetStringRepresentation();
}