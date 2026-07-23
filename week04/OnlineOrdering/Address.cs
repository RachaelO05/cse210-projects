public class Address
{
    private string _streetAddress;
    private string _city;
    private string _province;
    private string _country;

    public Address(string address, string city, string province, string country)
    {
        _streetAddress = address;
        _city = city;
        _province = province;
        _country = country;
    }

    public bool inUSA()
    {
        bool usa = false;
        if (_country.ToLower() == "usa")
        {
            usa = true;
        }

        return usa;
    }

    public string GetAddress()
    {
        return $"{_streetAddress}\n{_city}\n{_province}\n{_country}";
    }
}