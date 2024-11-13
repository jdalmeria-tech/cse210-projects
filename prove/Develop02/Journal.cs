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
        writer.WriteLine($"Date: {entry._date} | Prompt: {entry._promptText} | {entry._entryText}");
      }
    }
  }

  public void LoadFromFile(string file)
  {
    if (File.Exists(file))
    {
      string[] lines = File.ReadAllLines(file);
      foreach (string line in lines)
      {
        string[] parts = line.Split('|');
        if (parts.Length == 3)
        {
          Entry entry = new Entry(parts[0], parts[1], parts[2]);
          _entries.Add(entry);
        }
      }
    }
  }
}