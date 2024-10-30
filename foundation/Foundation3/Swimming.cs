public class Swimming : Activity
{
    //Attributes
    private double _lap;

    //Constructor
    public Swimming (double length, double lap) : base (length)
    {
        _length = length;
        _lap = lap;
    }

    //Methods

    public override double CalculateDistance()
    {
        return _lap * 50 / 1000 * 0.62;
    }

    public override double CalculateSpeed()
    {
        //Speed (mph or kph) = (distance / minutes) * 60
        return (CalculateDistance() / _length) * 60;
    }

    public override double CalculatePace()
    {
        return _length / CalculateDistance();
    }
}