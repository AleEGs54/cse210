public class EternalGoal : Goal
{
    //No attributes needed

    //Constructor
    public EternalGoal(string name, string description, string points) : base(name,description,points)
    {
        _shortname = name;
        _description = description;
        _points = points;
    }

    //Methods
    public override int RecordEvent()
    { //This method should do whatever is necessary for each specific kind of goal, such as marking a simple goal complete and adding to the number of times a checklist goal has been completed. It should return the point value associated with recording the event (keep in mind that it may contain a bonus in some cases if a checklist goal was just finished, for example).

        return int.Parse(_points);
        
    }

    public override bool IsComplete()
    { //This will always return fasle, because it can never be completed
        return false;
    }

    public override string GetStringRepresentation()
    {
        //This method returns a string that makes easy to write and read the goal from a txt file.
        return $"EternalGoal:{_shortname},{_description},{_points}";
    }
}