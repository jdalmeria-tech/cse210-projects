using System;
using System.Collections.Generic;
using System.Linq;
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
    var visibleWords = _words.Where(word => !word.IsHidden()).ToList();

    for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
    {
      int index = random.Next(visibleWords.Count);
      visibleWords[index].Hide();
      visibleWords.RemoveAt(index);
    }
  }

  public string GetDisplayText()
  {
    string scriptureText = string.Join(" ", _words.Select(word => word.GetDisplayText())); // (?)
    return $"{_reference.GetDisplayText()} {scriptureText}";
  }

  public bool IsCompletelyHidden()
  {
    return _words.All(word => word.IsHidden()); // (?)
  }

  public static void ClearConsole()
  {
    Console.Clear();
  }
}