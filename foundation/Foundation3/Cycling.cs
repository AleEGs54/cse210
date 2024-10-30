public class Cycling : Activity
{
    //Attributes
    private double _speed;

    //Constructor
    public Cycling (double length, double speed) : base (length)
    {
        _length = length;
        _speed = speed;
    }

    //Methods

    public override double CalculateDistance()
    {
        // Distance = minutes / pace
        return _length / CalculatePace();
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }

    public override double CalculatePace()
    {
        return 60 / _speed;
    }
}