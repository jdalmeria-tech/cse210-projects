using System;
using System.Collections.Generic;

public class Video
{
  public string _title;
  public string _author;
  public int _lengthSeconds;
  public List<Comment> _comments = new List<Comment>();

  // constructor to intialize video details
  public Video(string title, string author, int lengthSeconds)
  {
    _title = title;
    _author = author;
    _lengthSeconds = lengthSeconds;
  }

  // method to count the number of comments
  public int NumberOfComments()
  {
    return _comments.Count;
  }

  // display video details and comments
  public void DisplayInfo()
  {
    Console.WriteLine($"Video Title: {_title}");
    Console.WriteLine($"Creator: {_author}");
    Console.WriteLine($"Length: {_lengthSeconds / 60} min {_lengthSeconds % 60} sec");
    Console.WriteLine($"Number of Comments: {NumberOfComments()}");

    Console.WriteLine("\nComments:");
    foreach (Comment comment in _comments)
    {
      comment.DisplayInfo();
    }
    Console.WriteLine();
  }
}