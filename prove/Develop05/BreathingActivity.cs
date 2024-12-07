using System;

public class BreathingActivity : Activity
{
  // no attributes needed
  public BreathingActivity()
  {
  _name = "Breathing";
  _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
  _duration = 60;
  }

  public void RunTheActivity()
  {
    DisplayStartingMessage();

    for (int i = 0; i < _duration / 6; i++) // let's say it is 6 secs per cycle
    {
      Console.WriteLine("Breathe in twice...");
      ShowTimer(4);
      Console.WriteLine("Breathe out...");
      ShowTimer(5);
    }

    DisplayEndingMessage();
  }

}