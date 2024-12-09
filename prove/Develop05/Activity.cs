using System;
// references
// https://learn.microsoft.com/en-us/dotnet/api/system.console.setcursorposition?view=net-9.0
// https://stackoverflow.com/questions/51892943/set-cursor-position-relative-to-last-line-of-text-c-sharp-console-app
// https://www.w3schools.com/cs/cs_for_loop.php
// https://www.programiz.com/csharp-programming/for-loop
public class Activity
{
  protected string _name;
  protected string _description;
  protected int _duration;

  // constructor
  public Activity(string name, string description, int duration)
  {
    _name = name;
    _description = description;
    _duration = duration;
  }

  public void DisplayStartingMessage()
  {
    Console.WriteLine($"Welcome to the {_name} Activity.");
    Console.WriteLine($"\n{_description}");
    Console.WriteLine("\nHow long, in seconds, would you like for your session? ");
    _duration = int.Parse(Console.ReadLine());
    Console.Clear();
    Console.WriteLine("Get Ready...");
    ShowSpinner(5);
  }

  public void DisplayEndingMessage()
  {
    Console.WriteLine("Well done!!!");
    Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name} Activity (:");
    ShowSpinner(8);
    Console.Clear();
  }

  public void ShowSpinner(int seconds)
  {
    List<string> animationStrings = new List<string> {"|", "/", "-", "\\"};

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(seconds);

    int i = 0;

    while (DateTime.Now < endTime)
    {
      string s = animationStrings[i];
      Console.Write(s);
      Thread.Sleep(500);
      Console.Write("\b \b");

      i++;
      // this will reset the animation loop
      if (i >= animationStrings.Count)
      {
        i = 0;
      }
    }

    Console.WriteLine();
  }

  public void ShowTimer(int seconds)
  {
    for (int i = seconds; i > 0; i--)
    {
      Console.Write(i);
      Thread.Sleep(1000);
      Console.Write("\b \b");
    }
    Console.WriteLine();
  }
}