public class Customer
{
    //Attributes
    private string _name;
    private Address _address;

    //Constructor
    public Customer(string name, string address)
    {
        //Assigning the name attribute
        _name = name;

        //Assigning the address attribute
        //Dividing the address into parts 
        string[] parts = address.Split(",");

        //Assigning the parts of the string
        string street = parts[0];
        string city = parts[1];
        string state = parts[2];
        string country = parts[3];

        //Creating an instance of Address
        Address anAddress = new Address(street, city, state, country);
        _address = anAddress;

    }

    //Methods
    public bool ResidenceInUSA()
    {
        return _address.ResidenceInUSA();
    }

    public string DisplayShippingLabel()
    {
        return $"Ship to: \nCustomer: {_name} \nAddress: {_address.DisplayAddress()}";
    }
}