using System;
public class Assignment
{
  // attributes
  private string _studentName;
  private string _topic;

  // constructor
  public Assignment(string studentName, string topic)
  {
    _studentName = studentName;
    _topic = topic;
  }

  public string GetStudentName()
  {
    return _studentName;
  }
  public string GetSummary()
  {
    return $"{_studentName} - {_topic}";
  }
}