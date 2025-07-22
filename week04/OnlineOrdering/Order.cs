using System;

public class Order : Customer
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer) : base(customer.GetCustomerInfo().Name, customer.GetCustomerInfo().Street, customer.GetCustomerInfo().City, customer.GetCustomerInfo().State, customer.GetCustomerInfo().Country)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal GetTotalPrice()
    {
        if (_products.Count == 0)
        {
            return 0;
        }
        if (base.IsUSA())
        {
        return _products.Sum(p => p.GetTotalPrice()) + 5.00m; // Adding a flat shipping fee of $5.00 for USA orders
        }
        else
        {
            return _products.Sum(p => p.GetTotalPrice()) + 35.00m; // Adding a flat shipping fee of $35.00 for international orders
        }
    }
    public List<Product> GetProducts()
    {
        return _products;
    }
    public Customer GetCustomer()
    {
        return _customer;
    }
    public (string Name, string Street, string City, string State, string Country) GetShippingLabelInfo()
    {
        var customerInfo = _customer.GetCustomerInfo();
        return (customerInfo.Name, customerInfo.Street, customerInfo.City, customerInfo.State, customerInfo.Country);
    }

    public void GetShippingLabel()
    {
        var info = GetShippingLabelInfo();
        Console.WriteLine($"{info.Name}\n{info.Street}\n{info.City}, {info.State}\n{info.Country}");
    }

    public void GetOrderLabelDetails()
    {
        Console.WriteLine("Order Details:");
        Console.WriteLine("Products:");
        foreach (var product in _products)
        {
            var productInfo = product.GetProductInfo();
            Console.WriteLine($"- {productInfo.Name} (ID: {productInfo._Id}, Price: {productInfo.Price}, Quantity: {productInfo.Quantity})");
        }
        Console.WriteLine($"Total Price: ${GetTotalPrice()}");
    }
}