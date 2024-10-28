public abstract class Goal
{
    //Attributes
    protected string _shortname;
    protected string _description;
    protected string _points;

    //Constructor
    public Goal(string name, string description, string points)
    {
        _shortname = name;
        _description = description;
        _points = points;
    }

    //Methods
    public string GetShortName()
    {
        return _shortname;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        //This method needs to be the default for SimpleGoal and EternalGoal, but for ChecklistGoal it must be override.
        // This method should return the details of a goal that could be shown in a list. It should include the checkbox, the short name, and description. Then in the case of the ChecklistGoal class, it should be overridden to shown the number of times the goal has been accomplished so far.
        return IsComplete() ? $"[X] {_shortname} ({_description})" : $"[ ] {_shortname} ({_description})";
    }
    public abstract string GetStringRepresentation();
}