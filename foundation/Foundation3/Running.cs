public class Running : Activity
{
    //Attributes
    private double _distance;

    //Constructor
    public Running (double length, double distance) : base (length)
    {
        _length = length;
        _distance = distance;
    }

    //Methods

    public override double CalculateDistance()
    {
        return _distance;
    }

    public override double CalculateSpeed()
    {
        return _distance / _length * 60;
    }

    public override double CalculatePace()
    {
        return _length / _distance;
    }
}