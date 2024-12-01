using System;

public class Customer
{
  // attributes
  private string _name;
  private Address _address;

  // constructor
  public Customer(string name, Address address)
  {
    _name = name;
    _address = address;
  }

  // behaviors
  public string GetName()
  {
    return _name;
  }

  public bool IsUsa()
  {
    return _address.IsUSA();
  }

  public string GetShippingInfo()
  {
    return $"{_name}\n{_address.GetFullAddress()}";
  }
}