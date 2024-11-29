using System;

public class Comment
{
  public string _name;
  public string _text;

  // constructor to initialize comment details
  public Comment(string name, string text)
  {
    _name = name;
    _text = text;
  }

  public void DisplayInfo()
  {
    Console.WriteLine($"{_name}: {_text}");
  }
}