public abstract class Activity
{
    //Attributes
    private string _date;
    protected double _length;

    //Constructor
    public Activity(double length)
    {
        _length = length;
        
        //date - incomplete
        DateTime currentDate = DateTime.Now;
        int day = currentDate.Day;
        string month = currentDate.ToString("MMM");
        int year = currentDate.Year;
        _date = $"{day} {month} {year}";

    }

    //Methods
    public virtual void GetSummary()
    {
        Type type = this.GetType(); //Retrieves the type of the object
        Console.WriteLine($"{_date} {type} ({_length} min) - Distance: {CalculateDistance():F2} miles, Speed: {CalculateSpeed():F2} mph, Pace: {CalculatePace():F2} min per mile");
    }

    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();
    
}