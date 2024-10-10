public class Address
{
    //Attributes
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    //Constructor
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public Address(string street, string city, string state)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = "USA";

    }

    //Methods

    public bool ResidenceInUSA()
    {
        if (_country.ToLower() == "usa" || _country.ToLower() == "us")
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public string DisplayAddress()
    {
        //123 S Main St, Rexburg, Idaho, US/USA
        return $"{_street}, {_city}, {_state}, {_country}";
    }
}