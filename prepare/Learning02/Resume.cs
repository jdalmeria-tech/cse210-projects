using System;

public class Resume
{
  public string _name = "";
  public List<Job> _jobs = new List<Job>();

  public void DisplayInfo()
  {
    Console.WriteLine($"Name: {_name}");
    Console.WriteLine($"Jobs:");

    // create a loop
    foreach (Job job in _jobs)
    {
      job.DisplayInfo();
    }
  }
}