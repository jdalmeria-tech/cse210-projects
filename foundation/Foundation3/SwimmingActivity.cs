using System;

public class SwimmingActivity : Activity
{
  private int _laps;

  public SwimmingActivity(string date, int durationMinutes, int laps) : base (date, durationMinutes)
  {
    _laps = laps;
  }

    public override double CalculateDistance()
    {
        return (_laps * 50) / 1000.0;
    }

    public override double CalculateSpeed()
    {
        return (CalculateDistance() / GetDurationMinutes()) * 60;
    }

    public override double CalculatePace()
    {
        return GetDurationMinutes() / CalculateDistance();
    }
}