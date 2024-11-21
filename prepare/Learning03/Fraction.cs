public class Fraction
{
  // atributes...
  private int _top;
  private int _bottom;

  // constructors...
  // initialize 1/1; this is just a default
  // remember denominator (bottom) MUST not be zero(0)
  public Fraction()
  {
    _top = 1;
    _bottom = 1;
  }

  public Fraction (int wholeNumber)
  {
    _top = wholeNumber;
    _bottom = 1;
  }

  public Fraction (int top, int bottom)
  {
    if (bottom == 0)
    {
      throw new ArgumentException("Denominator cannot be zero.");
    }

    _top = top;
    _bottom = bottom;

  }

  // getters and setters...
  public int GetTop()
  {
    return _top;
  }

  public void SetTop (int top)
  {
    _top = top;
  }

  public int GetBottom()
  {
    return _bottom;
  }

  public void SetBottom (int bottom)
  {
    if (bottom == 0)
    {
      throw new ArgumentException("Denominator cannot be zero.");
    }

    _bottom = bottom;
  }

  // methods...
  public string GetFractionString()
  {
    return $"{_top}/{_bottom}";
  }

  public double GetDecimalValue()
  {
    return (double)_top / _bottom;
  }

}