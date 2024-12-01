using System;

// reference
// https://www.w3schools.com/cs/cs_data_types.php
public class Product
{
  // attributes
  private string _name;
  private string _id;
  private double _price;
  private int _quantity;

  // constructors

  // behaviors
  public double CalculateCost()
  {
    return _price * _quantity;
  }
}