using System;
// references
// https://learn.microsoft.com/en-us/dotnet/api/system.string.isnullorempty?view=net-9.0
// https://www.geeksforgeeks.org/c-sharp-isnullorempty-method/
// https://www.educative.io/answers/how-to-check-if-a-string-is-null-or-empty-in-c-sharp
// https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.count?view=net-9.0
// https://dotnettutorials.net/lesson/linq-count-method/#google_vignette

public class ListingActivity : Activity
{
  private int _count;
  private List<string> _prompts = new List<string>
  {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are the people that you have helped this week?",
    "When have you felt the Holy Ghost this week?",
    "Who are some of your personal heroes?",
    "What were the emotions that you have felt and validated this week?",
  };

  public ListingActivity()
  {
    _name = "Listing";
    _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    _duration = 60;
  }
  // constructor
  public void RunTheActivity()
  {
    DisplayStartingMessage();

    string prompt = GetRandomPrompt();
    Console.WriteLine("List as many responses as you can to the following prompt:");
    Console.WriteLine($"--- {prompt} ---");
    Console.WriteLine("You may begin in: ");
    ShowTimer(5);
    Console.Write("> ");

    List<string> userList = GetListFromUser();
    Console.WriteLine($"You listed {userList.Count} items! (:");

    DisplayEndingMessage();
  }

  public string GetRandomPrompt()
  {
    Random random = new Random();
    return _prompts[random.Next(_prompts.Count)];
  }

  public List<string> GetListFromUser()
  {
    List<string> list = new List<string>();
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(_duration);

    while (startTime < endTime)
    {
      string input = Console.ReadLine();
      if (!string.IsNullOrEmpty(input))
          list.Add(input);
    }
    return list;
  }
}