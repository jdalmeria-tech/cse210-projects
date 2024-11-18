public class Fraction
{
  private int _top;
  private int _bottom;

// initialize 0/1; this is just a default
// remember denominator (bottom) MUST not be zero(0)
  public Fraction()
  {
    _top = 0;
    _bottom = 1; 
  }

  public Fraction (int wholeNumber)
  {
    wholeNumber = _top / _bottom;
  }

  public Fraction (int top, int bottom)
  {
    _top = top;
    _bottom = bottom;
  }

  





}