using System;

public class Video
{
  public string _title;
  public string _author;
  public int _lengthSeconds;

  public List<Comment> _comments = new List<Comment>();

  public void DisplayInfo()
  {
    Console.WriteLine($"Video Title: {_title}");
    Console.WriteLine($"Creator: {_author}");
  }
}