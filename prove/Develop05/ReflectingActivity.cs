using System;

// references
// https://learn.microsoft.com/en-us/dotnet/api/system.random.next?view=net-9.0
// ChatGPT was also used for this class, I asked for ways to make sure that as user enters the duration
// number, it gives the exact number remainingDuration was added/implemented
// https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.removeat?view=net-9.0
// https://www.tutorialspoint.com/what-is-the-removeat-method-in-chash-lists
// 
public class ReflectingActivity : Activity
{
  private List<string> _prompts = new List<string>
  {
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless.",
    "Think of an experience when you were having a hard time forgiving someone."
  };
  private List<string> _questions = new List<string>
  {
    "> Why was this experience meaningful to you?",
    "> Have you ever done anything like this before?",
    "> How did you get started?",
    "> What made this time, different than other times when you were not as successful?",
    "> What is your favorite thing about this experience?",
    "> What could you learn from this experience that applies to other situations?",
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
    ShowTimer(8);

    int remainingDuration = _duration; // copy the duration for countdown
    DisplayQuestions(ref remainingDuration); // cycles thru random questions

    DisplayEndingMessage();
  }

  // this retrieves random item from a list and removes it to ensure
  // it only appears once
  // if the list is empty it will return a placeholder message
  private string GetRandomItemAndRemove(ref List<string> list)
  {
    if (list.Count == 0)
    {
      return "No more items to display...";
    }

    Random random = new Random();
    int index = random.Next(list.Count);
    string item = list[index];
    list.RemoveAt(index);
    return item;
  }

  // public string GetRandomQuestion()
  // {
  //   Random random = new Random();
  //   return _questions[random.Next(_questions.Count)];
  // }

  public void DisplayPrompt()
  {
    if (_prompts.Count > 0)
    {
      string prompt = GetRandomItemAndRemove(ref _prompts); // picks a prompt then removes it
      Console.WriteLine("Consider the following prompt:");
      Console.WriteLine($"--- {prompt} ---");
      Console.WriteLine("When you have something in mind, press enter to continue.");
      Console.ReadLine();
      ShowSpinner(8);
    }
    else
    {
      Console.WriteLine("All prompts have been used (:");
    }
    
  }

  public void DisplayQuestions(ref int remainingDuration)
  {
    while (remainingDuration > 0 &&_questions.Count > 0)
    {
      string question = GetRandomItemAndRemove(ref _questions); // picks a question and removes it
      Console.WriteLine(question);
      ShowSpinner(8); // let's say that it takes 8s per question reflection
      remainingDuration -= 8; // decrease the time
    }

    if (_questions.Count == 0)
    {
      Console.WriteLine("All questions have been used (:");
    }
  }
}