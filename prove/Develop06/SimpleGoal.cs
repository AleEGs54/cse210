public class SimpleGoal : Goal
{
    //Attributes
    private bool _isComplete;

    //Constructor

    public SimpleGoal(string name, string description, string points) : base(name,description,points)
    {
        _shortname = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    //Methods
    public override int RecordEvent()
    { //This method should do whatever is necessary for each specific kind of goal, such as marking a simple goal complete and adding to the number of times a checklist goal has been completed. It should return the point value associated with recording the event (keep in mind that it may contain a bonus in some cases if a checklist goal was just finished, for example).

        //This is all for the SimpleGoal
        _isComplete = true;
        return int.Parse(_points);
    }

    public override bool IsComplete()
    {
        
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        //This method returns a string that makes easy to write and read the goal from a txt file.
        return $"SimpleGoal:{_shortname},{_description},{_points},{_isComplete}";
    }
}