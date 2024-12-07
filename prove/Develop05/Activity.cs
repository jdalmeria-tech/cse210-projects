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

  public Activity(string name, string description, int duration)
  {
    _name = name;
    _description = description;
    _duration = duration;
  }

  public void DisplayStartingMessage()
  {
    Console.WriteLine($"Welcome to the {_name} Activity.");
    Console.WriteLine(_description);
    Console.WriteLine("How long, in seconds, would you like for your session? ");
    _duration = int.Parse(Console.ReadLine());
    Console.WriteLine("Get Ready...");
    ShowSpinner(3);
  }

  public void DisplayEndingMessage()
  {
    Console.WriteLine("Well done!!!");
    Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity (:");
    ShowSpinner(3);
  }

  public void ShowSpinner(int seconds)
  {
    string[] spinner = {"\\", "|", "/", "-"};
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(seconds);
    int index = 0;

    while (startTime < endTime)
    {
      Console.Write(spinner[index]);
      Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop); // this makes the code shorter to overwrite the symbol
      index = (index + 1) % spinner.Length;
      Thread.Sleep(255);
    }
    Console.WriteLine();
  }

  public void ShowTimer(int seconds)
  {
    for (int i = seconds; i > 0; i--)
    {
      Console.WriteLine($"{i}(s)");
      Thread.Sleep(1000);
    }
    Console.WriteLine();
  }
}