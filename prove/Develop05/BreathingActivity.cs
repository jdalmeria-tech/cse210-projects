using System;

public class BreathingActivity : Activity
{
  // no attributes needed

  // constructor
  public BreathingActivity() : base ("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 60)
  {
    // nothing to initialize
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