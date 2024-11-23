using System;
// reference
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator
public class Reference
{
  private string _book;
  private int _chapter;
  private int _verse;
  private int _endVerse;

  // constructor for single verse
  public Reference(string book, int chapter, int verse)
  {
    _book = book;
    _chapter = chapter;
    _verse = verse;
    _endVerse = -1;
  }

  // constructor for multiple verses
    public Reference(string book, int chapter, int startVerse, int endVerse)
  {
    _book = book;
    _chapter = chapter;
    _verse = startVerse;
    _endVerse = endVerse;
  }
  
  public string GetDisplayText()
  {
    return _endVerse == -1
          ? $"{_book} {_chapter}:{_verse}"
          : $"{_book} {_chapter}:{_verse}-{_endVerse}";
  }
}