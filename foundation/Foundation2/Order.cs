using System.Text;

public class Order
{
    //Attributes
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    //Constructor
    public Order(string name, string address)
    {
        //Creating an instance of customer
        Customer customer = new Customer(name, address);
        _customer = customer;
    }

    //Methods 
    public void AddProduct(string name, int id, float price, int quantity)
    {
        Product product = new Product(name, id, price, quantity);
        _products.Add(product);
    }

    public string OrderTotalCost()
    {
        float totalCost = 0;
        int shippingCost;
        foreach (Product product in _products)
        {
            totalCost += product.TotalCost();
        }

        if (_customer.ResidenceInUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        float finalCost = totalCost + shippingCost;

        return $"\nThe total cost is: {finalCost}";
    }

    public string PackingLabel()
    {
        //Creating an instance of stringbuilder to concatenate the labels
        StringBuilder labels = new StringBuilder();

        foreach (Product product in _products)
        {
            labels.Append(product.DisplayPackingLabel());

        }
        return $"\nPackage Content:\n{labels}";
    }

    public string ShippingLabel()
    {

        return $"{_customer.DisplayShippingLabel()}";
    }
}