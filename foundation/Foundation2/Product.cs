using System;

// reference
// https://www.w3schools.com/cs/cs_data_types.php
public class Product
{
  // attributes
  private string _name;
  private string _id;
  private decimal _price;
  private int _quantity;

  // constructor
  public Product(string name, string id, decimal price, int quantity)
  {
    _name = name;
    _id = id;
    _price = price;
    _quantity = quantity;
  }

  // behaviors
  public decimal CalculateCost()
  {
    return _price * _quantity;
  }

  public string GetPackingInfo()
  {
    return $"{_name} (ID: {_id})";
  }
}