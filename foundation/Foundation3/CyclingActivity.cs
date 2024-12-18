using System;

public class CyclingActivity : Activity
{
  private double _speedKph;

  public CyclingActivity(string date, int durationMinutes, double speedKph) : base (date, durationMinutes)
  {
    _speedKph = speedKph;
  }

    public override double CalculateDistance()
    {
        return (_speedKph * GetDurationMinutes()) / 60;
    }

    public override double CalculateSpeed()
    {
        return _speedKph;
    }

    public override double CalculatePace()
    {
        return 60 / _speedKph;
    }
}