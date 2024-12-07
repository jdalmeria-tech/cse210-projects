using System;

// references
// https://learn.microsoft.com/en-us/dotnet/api/system.random.next?view=net-9.0
public class ReflectingActivity : Activity
{
  private List<string> _prompts = new List<string>
  {
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."
  };
  private List<string> _questions = new List<string>
  {
    "> Why was this experience meaningful to you?",
    "> Have you ever done anything like this before?",
    "> How did you get started?",
    "> What made this time, different than other times when you were not as successful?",
    "> What is your favorite thing about this experience?",
    "> What coudl you learn from this experience that applies to other situations?",
    "> What did you learn about yourself through this experience?",
    "> How can you keep this experience in mind in the future?"
  };
  // constructor
  public ReflectingActivity() : base ("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 60)
  {
    // nothing to initialize
  }

  public void RunTheActivity()
  {
    DisplayStartingMessage();

    DisplayPrompt(); // this shows the random prompt

    Console.WriteLine("Now ponder on the following questions as they relate to this experience.");
    Console.Write("You may begin in: ");
    ShowTimer(5);

    DisplayQuestions(); // cycles thru random questions

    DisplayEndingMessage();
  }
  public string GetRandomPrompt()
  {
    Random random = new Random();
    return _prompts[random.Next(_prompts.Count)];
  }

  public string GetRandomQuestion()
  {
    Random random = new Random();
    return _questions[random.Next(_questions.Count)];
  }

  public void DisplayPrompt()
  {
    string prompt = GetRandomPrompt();
    Console.WriteLine("Consider the following prompt:");
    Console.WriteLine($"--- {prompt} ---");
    Console.WriteLine("When you have something in mind, press enter to continue.");
    Console.ReadLine();
    ShowSpinner(5);
  }

  public void DisplayQuestions()
  {
    while (_duration > 0)
    {
      string question = GetRandomQuestion();
      Console.WriteLine(question);
      ShowSpinner(7);
      _duration -= 7;
    }
  }
}