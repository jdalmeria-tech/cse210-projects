using System;

public class RunningActivity : Activity
{
  private double _distanceKm;

  public RunningActivity(string date, int durationMinutes, double distanceKm) : base (date, durationMinutes)
  {
    _distanceKm = distanceKm;
  }

    public override double CalculateDistance()
    {
        return _distanceKm;
    }

    public override double CalculateSpeed()
    {
        return (_distanceKm / GetDurationMinutes()) * 60;
    }

    public override double CalculatePace()
    {
        return GetDurationMinutes() / _distanceKm;
    }
}