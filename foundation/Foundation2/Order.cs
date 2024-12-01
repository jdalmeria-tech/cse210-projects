using System;

public class Order
{
  // attributes
  private Customer _customer;
  private List<Product> _products;

  // constructors

  // behaviors
  public string GetPackingLabel()
  {
    return "";
  }

  public string GetShippingLabel()
  {
    return "";
  }

  public float CalculateTotalCost()
  {
    return -1;
  }
}