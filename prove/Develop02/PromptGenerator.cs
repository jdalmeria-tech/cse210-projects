using System;
public class PromptGenerator
{
  private List<string> _prompts = new List<string>
  {
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    "What actions did I take today that I can say I improved by 1%?",
    "Who made my day, and how did that person do it?",
    "What am I grateful for today?",
    "How did I make someone smile for today?",
    "What mistakes have I made, and what can I learn from them?",
    "What actions did I take to validate my emotions?",
    "Have I done any good in the world today?"
  };

  // get a random prompt
  public string GetRandomPrompt()
  {
    Random random = new Random();
    int index = random.Next(_prompts.Count);
    return _prompts[index];
  }
  
}