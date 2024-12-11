using System;
public class Circle : Shape
{
  private double _radius;

  public override double GetArea()
  {
    return Math.PI * _radius * _radius;
  }
}