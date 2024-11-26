using System;

public class Comment
{
  public string _name;
  public string _text;

  public void DisplayInfo()
  {
    Console.WriteLine($"{_name}: {_text}");
  }
}