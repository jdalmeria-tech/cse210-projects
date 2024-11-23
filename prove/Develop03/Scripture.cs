using System;
using System.Collections.Generic;
using System.Linq;
// references
// https://learn.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split
// https://csharp.net-tutorials.com/linq/data-transformations-the-select-method/#google_vignette
// https://stackoverflow.com/questions/3801748/select-method-in-listt-collection
// https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.where?view=net-9.0
// https://www.tutorialsteacher.com/csharp/csharp-list
// https://learn.microsoft.com/en-us/dotnet/api/system.string.join?view=net-9.0
// https://learn.microsoft.com/en-us/dotnet/csharp/linq/
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-operator
public class Scripture
{
  private Reference _reference;
  private List<Word> _words;

  // contructor accepts reference and the full text of the scripture verse
  public Scripture(Reference reference, string text)
  {
    _reference = reference;
    _words = text.Split(' ').Select(word => new Word(word)).ToList();
  }

  // class behaviors
  public void HideRandomWords(int numberToHide)
  {
    Random random = new Random();
    var visibleWords = _words.Where(word => !word.IsHidden()).ToList(); // include only words that are NOT hidden then convert to a list

    for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
    {
      int index = random.Next(visibleWords.Count);
      visibleWords[index].Hide();
      visibleWords.RemoveAt(index);
    }
  }

  public string GetDisplayText()
  {
    string scriptureText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
    return $"{_reference.GetDisplayText()} {scriptureText}";
  }

  public bool IsCompletelyHidden()
  {
    return _words.All(word => word.IsHidden());
  }

  public static void ClearConsole()
  {
    Console.Clear();
  }
}