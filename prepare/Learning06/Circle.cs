

public class Circle : Shape{

    private double _radio;


    //Constructor

    public Circle(double radio, string color):base(color)
    {
        _radio = radio;
    }

    public override double GetArea()
    {
        return Math.PI * (_radio *_radio);
    }

}