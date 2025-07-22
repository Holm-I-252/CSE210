using System;

public class Address
{
    private string _Street_Address;
    private string _City;
    private string _State;
    private string _Country;

    public Address(string street, string city, string state, string country)
    {
        _Street_Address = street;
        _City = city;
        _State = state;
        _Country = country;
    }

    public string GetFullAddress()
    {
        return $"{_Street_Address}\n{_City}, {_State}\n{_Country}";
    }

    public (string Street, string City, string State, string Country) GetAddressInfo()
    {
        return (_Street_Address, _City, _State, _Country);
    }

    public bool IsUSA()
    {
        if (_Country == "USA")
        {
            return true;
        }
        return false;
    }
}