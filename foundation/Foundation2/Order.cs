using System;
using System.Collections.Generic;

public class Order
{
  // attributes
  private Customer _customer;
  private List<Product> _products;

  // constructor
  public Order(Customer customer)
  {
    _customer = customer;
    _products = new List<Product>();
  }

  // behaviors
  public void AddProduct(Product product)
  {
    _products.Add(product);
  }
  public string GetPackingLabel()
  {
    string packingLabel = "Packing Label:\n";
    foreach (var product in _products)
    {
      packingLabel += $"{product.GetPackingInfo()}\n";
    }
    return packingLabel;
  }

  public string GetShippingLabel()
  {
    return $"Shipping Label:\n{_customer.GetShippingInfo()}";
  }

  public decimal CalculateTotalCost()
  {
    decimal totalCost = 0;

    // sum up product costs
    foreach(var product in _products)
    {
      totalCost += product.CalculateCost();
    }

    // add shipping cost
    totalCost += _customer.IsUsa() ? 5m : 35m;

    return totalCost;
  }
}