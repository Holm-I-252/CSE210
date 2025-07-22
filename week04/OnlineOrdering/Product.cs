using System;
using System.Diagnostics.Contracts;

public class Product
{
    private string Name;
    private int _Id ;
    private double Price;
    private double Quantity;

    public Product(string name, int id, double price, double quantity = 0)
    {
        Name = name;
        _Id = id;
        Price = price;
        Quantity = quantity;
    }

    public int GetTotalPrice()
    {
        return (int)(Price * Quantity);
    }

    public (string Name, int _Id, double Price, double Quantity) GetProductInfo()
    {
        return (Name, _Id, Price, Quantity);
    }

    
}