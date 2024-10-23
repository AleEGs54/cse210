public class Rectangle : Shape{
    //Attribute
    private double _width;
    private double _lenght;

    //Constructor

    public Rectangle(double width, double lenght, string color):base(color)
    {
        _width = width;
        _lenght = lenght;
    }

    public override double GetArea()
    {
        return _width * _lenght;
    }
}