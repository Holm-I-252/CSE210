using System;

public class Customer : Address
{
    private string _Name;

    public Customer(string name, string street, string city, string state, string country) : base(street, city, state, country)
    {
        _Name = name;
    }

    public new bool IsUSA()
    {
        return base.IsUSA();
    }

    public (string Name, string Street, string City, string State, string Country) GetCustomerInfo()
    {
        var addressInfo = base.GetAddressInfo();
        return (_Name, addressInfo.Street, addressInfo.City, addressInfo.State, addressInfo.Country);
    }

}