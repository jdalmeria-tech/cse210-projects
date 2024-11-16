using System;
public class Entry
{
  public DateTime _date;
  public string _promptText;
  public string _entryText;

  public Entry(DateTime date, string promptText, string entryText)
  {
    _date = date;
    _promptText = promptText;
    _entryText = entryText;
    
  }

  public void Display()
  {
    Console.WriteLine($"Date: {_date.ToString("dd-MM-yyyy")}");
    Console.WriteLine(_promptText);
    Console.WriteLine($"> {_entryText}");
    Console.WriteLine();
  }

}