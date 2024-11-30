using System;

public class Address
{
  // attributes
  private string _street;
  private string _city;
  private string _state;
  private string _country;

  // constructor(s)
  public Address(string street, string city, string state, string country)
  {
    _street = street;
    _city = city;
    _state = state;
    _country = country;
  }

  // behaviors
  public string GetFullAddress()
  {
    return $"Address: {_street} {_city} {_state} {_country}";
  }
}