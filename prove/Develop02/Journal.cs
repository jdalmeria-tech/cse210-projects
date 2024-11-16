using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
  public List<Entry> _entries = new List<Entry>();

  public void AddEntry(Entry newEntry)
  {
    _entries.Add(newEntry);
  }

  public void DisplayAll()
  {
    foreach (var entry in _entries)
    {
      entry.Display();
    }
  }

  public void SaveToFile(string file)
  {
    using (StreamWriter writer = new StreamWriter(file))
    {
      foreach (var entry in _entries)
      {
        writer.WriteLine(entry._date.ToString("dd-MM-yyyy"));
        writer.WriteLine(entry._promptText);
        writer.WriteLine(entry._entryText);
        writer.WriteLine("---");
      }
    }
  }

  public void LoadFromFile(string file)
  {
    if (File.Exists(file))
    {
      _entries.Clear();
      string[] lines = File.ReadAllLines(file);
      for (int i = 0; i < lines.Length; i +=4) // 4 lines for each entry(date, prompt, text, and the separator)
      {
        if (i + 2 < lines.Length)
        {
          DateTime date = DateTime.Parse(lines[i]);
          string promptText = lines[i + 1];
          string entryText = lines[i + 2];
          _entries.Add(new Entry(date, promptText, entryText));
        }
      }
    }
    else
    {
      Console.WriteLine("File not found...");
    }
  }
}