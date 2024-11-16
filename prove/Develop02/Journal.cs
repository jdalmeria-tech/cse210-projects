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

  // this method can save csv and txt files
  public void SaveToFile(string file)
  {
      if (file.EndsWith(".csv", StringComparison.OrdinalIgnoreCase))
      {
          // save as CSV
          using (StreamWriter outputFile = new StreamWriter(file))
          {
              outputFile.WriteLine("Date,Prompt,Entry"); // CSV header
              foreach (var entry in _entries)
              {
                  string date = entry._date.ToString("dd-MM-yyyy");
                  string prompt = EscapeForCsv(entry._promptText);
                  string entryText = EscapeForCsv(entry._entryText);

                  outputFile.WriteLine($"{date},{prompt},{entryText}"); // write CSV row
              }
          }

          Console.WriteLine("Journal entries saved successfully as CSV!");
      }
      else if (file.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
      {
          // save as plain text
          using (StreamWriter outputFile = new StreamWriter(file))
          {
              foreach (var entry in _entries)
              {
                  outputFile.WriteLine("Date: " + entry._date.ToString("dd-MM-yyyy"));
                  outputFile.WriteLine("Prompt: " + entry._promptText);
                  outputFile.WriteLine("Entry: " + entry._entryText);
                  outputFile.WriteLine("----------------------");
              }
          }

          Console.WriteLine("Journal entries saved successfully as plain text!");
      }
      else
      {
          Console.WriteLine("Unsupported file format. Please use '.csv' or '.txt'.");
      }
  }


  // this method ensures any special characters like commas, quotes or
  // newlines are correctly handled
  private string EscapeForCsv(string input)
  {
    if (input.Contains(",") || input.Contains("\"") || input.Contains("\n"))
    {
      // escape the quotes by doubling them
      input = input.Replace("\"", "\"\"");

      // wrap the entire field in quotes
      return $"\"{input}\"";
    }

    return input; 
  }

  // this method can load csv and txt files
  public void LoadFromFile(string file)
  {
      if (File.Exists(file))
      {
          _entries.Clear();

          if (file.EndsWith(".csv", StringComparison.OrdinalIgnoreCase))
          {
              // load as CSV
              string[] lines = File.ReadAllLines(file);

              for (int i = 1; i < lines.Length; i++) // skip the header
              {
                  string line = lines[i];
                  string[] parts = ParseCsvLine(line);

                  if (parts.Length == 3)
                  {
                      try
                      {
                          DateTime date = DateTime.ParseExact(parts[0], "dd-MM-yyyy", null);
                          string promptText = UnescapeFromCsv(parts[1]);
                          string entryText = UnescapeFromCsv(parts[2]);

                          _entries.Add(new Entry(date, promptText, entryText));
                      }
                      catch (Exception ex)
                      {
                          Console.WriteLine($"Error parsing line {i + 1}: {ex.Message}");
                      }
                  }
                  else
                  {
                      Console.WriteLine($"Skipping malformed line {i + 1}: {line}");
                  }
              }

              Console.WriteLine("Journal entries loaded successfully from CSV!");
          }
          else if (file.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
          {
              // load as plain text
              string[] lines = File.ReadAllLines(file);

              for (int i = 0; i < lines.Length; i += 4) // each entry is 4 lines + separator
              {
                  if (i + 2 < lines.Length)
                  {
                      try
                      {
                          // trim each line to avoid leading/trailing whitespace issues
                          string dateLine = lines[i].Trim(); // e.g., "Date: 16-11-2024"
                          string promptLine = lines[i + 1].Trim(); // e.g., "Prompt: What did you learn today?"
                          string entryLine = lines[i + 2].Trim(); // e.g., "Entry: I learned C#"

                          // extract fields
                          DateTime date = DateTime.ParseExact(dateLine.Substring(6), "dd-MM-yyyy", null); // parse date after "Date: "
                          string promptText = promptLine.Substring(8); // extract after "Prompt: "
                          string entryText = entryLine.Substring(7); // extract after "Entry: "

                          _entries.Add(new Entry(date, promptText, entryText));
                      }
                      catch (Exception ex)
                      {
                          Console.WriteLine($"Error parsing entry starting at line {i + 1}: {ex.Message}");
                      }
                  }
              }

              Console.WriteLine("Journal entries loaded successfully from plain text!");
          }
          else
          {
              Console.WriteLine("Unsupported file format. Please use '.csv' or '.txt'.");
          }
      }
      else
      {
          Console.WriteLine("File not found...");
      }
  }


  // handles the proper slitting of CSV fields
  private string[] ParseCsvLine(string line)
  {
      List<string> result = new List<string>();
      bool inQuotes = false;
      string currentField = "";

      foreach (char c in line)
      {
          if (c == '"' && (currentField.Length == 0 || inQuotes))
          {
              // toggle the inQuotes flag if we encounter a quote
              inQuotes = !inQuotes;
          }
          else if (c == ',' && !inQuotes)
          {
              // if not in quotes, comma indicates end of the field
              result.Add(currentField);
              currentField = "";
          }
          else
          {
              // add character to the current field
              currentField += c;
          }
      }

      // add the last field
      if (currentField.Length > 0)
      {
          result.Add(currentField);
      }

      return result.ToArray();
  }


  // reverse the escaping process, this handles quotes properly
  private string UnescapeFromCsv(string input)
  {
      // remove wrapping quotes, if present
      if (input.StartsWith("\"") && input.EndsWith("\""))
      {
          input = input.Substring(1, input.Length - 2); // remove the outer quotes
          input = input.Replace("\"\"", "\""); // replace doubled quotes with a single quote
      }
      return input;
  }

}