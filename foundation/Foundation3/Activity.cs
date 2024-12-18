using System;
// references:
// https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-9.0
// https://learn.microsoft.com/en-us/dotnet/api/system.datetime.now?view=net-9.0
// https://learn.microsoft.com/en-us/dotnet/api/system.datetime.tostring?view=net-9.0
// https://stackoverflow.com/questions/74180235/datetime-returns-wrong-string-on-tostringstring-format
// https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings
// https://stackoverflow.com/questions/8401605/c-sharp-datetime-parseexact
// https://learn.microsoft.com/en-us/dotnet/api/system.datetime.parseexact?view=net-9.0
public abstract class Activity
{
  private DateTime _date;
  private int _durationMinutes;

  protected Activity(string date, int durationMinutes)
  {
    _date = DateTime.ParseExact(date, "dd MMM yyyy", System.Globalization.CultureInfo.InvariantCulture);
    _durationMinutes = durationMinutes;
  }

  public string GetDate()
  {
    return _date.ToString("dd MMM yyyy");
  }

  public int GetDurationMinutes()
  {
    return _durationMinutes;
  }

  public abstract double CalculateDistance();
  public abstract double CalculateSpeed();
  public abstract double CalculatePace();

  public virtual string GetSummary()
  {
    return $"{GetDate()} {GetType().Name} ({GetDurationMinutes()}) min: " +
           $"Distance: {CalculateDistance():F2} km, " +
           $"Speed: {CalculateSpeed():F2} kph, " +
           $"Pace: {CalculatePace():F2} min per km";
  }
}