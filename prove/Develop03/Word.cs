using System;
public class Word
{
  private string _text;
  private bool _isHidden;

  // constructors
  public Word( string text)
  {
    _text = text;
    _isHidden = false; // by default, words are visible
  }

  public void Hide()
  {
    _isHidden = true;
  }
  public void Show()
  {
    _isHidden = false;
  }
  public bool IsHidden()
  {
    return _isHidden;
  }

  // class behavior
  public string GetDisplayText()
  {
    return _isHidden ? new string('_',_text.Length) : _text;
  }
}