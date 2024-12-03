using System;
public class WritingAssignment : Assignment
{
  private string _title;

  // constructor using base
  public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
  {
    _title = title;
  }

  public string GetWritingInformation()
  {
    return $"{_title} by {GetStudentName()}";
  }
}