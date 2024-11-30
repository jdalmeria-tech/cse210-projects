using System;

public class Customer
{
  // attributes
  private string _name;
  // private string _address;

  // constructors
  public Customer(string name)
  {
    _name = name;
    // _address = false;
  }

  // behaviors
  public string GetName()
  {
    return $"Name: {_name}";
  }

  // public bool IsUsa()
  // {
  //   return _address;
  // }
}