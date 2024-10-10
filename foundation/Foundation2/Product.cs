public class Product
{
    //Attributes
    private string _productName;
    private int _productId;
    private float _price;
    private int _quantity;

    //Constructor
    public Product(string name, int id, float price, int quantity)
    {
        _productName = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }

    //Methods
    public float TotalCost()
    {
        return _price * _quantity;
    }

    public string DisplayPackingLabel()
    {
        return $"Product: {_productName} - ID: {_productId} \n";
    }
}