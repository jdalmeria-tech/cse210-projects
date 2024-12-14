using System;

public class GoalManager
{
  private List<Goal> _goals;
  private int _score;

  public GoalManager()
  {
    _score = 0;
  }

  public void Start()
  {
    //needs to improve This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
  }

  public void DisplayPlayerInfo()
  {
    //needs to improve Displays the players current score.
  }

  public void ListGoalNames()
  {
    //needs to improve Lists the names of each of the goals.
  }

  public void ListGoalDetails()
  {
    //needs to improve Lists the details of each goal (including the checkbox of whether it is complete).
  }

  public void CreateGoal()
  {
    // needs to improve Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
  }

  public void RecordEvent()
  {
    //needs to improve Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
  }

  public void SaveGoals()
  {
    //needs to improve Saves the list of goals to a file.
  }

  public void LoadGoals()
  {
    //needs to improve Loads the list of goals from a file.
  }

}