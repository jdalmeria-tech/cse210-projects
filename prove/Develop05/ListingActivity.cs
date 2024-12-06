using System;

public class ListingActivity : Activity
{
  private int _count;
  private List<string> _prompts;

  public ListingActivity()
  {
    _name = "Listing";
    _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    _duration = 60;
  }

  public void RunTheActivity()
  {

  }

  public string GetRandomPrompt()
  {
    return "";
  }

  public List<string> GetListFromUser()
  {
  
  }


}