public class ChecklistGoal : Goal
{
    //Attributes
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    //Constructor

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name,description,points)
    {
        _shortname = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    //Methods
    public override int RecordEvent()
    { //This method should do whatever is necessary for each specific kind of goal, such as marking a simple goal complete and adding to the number of times a checklist goal has been completed. It should return the point value associated with recording the event (keep in mind that it may contain a bonus in some cases if a checklist goal was just finished, for example).

    //_amountCompleted increases by 1 each time RecordEvent is called and if it's equal to the target it returns the points plus the bonus, otherwise it just returns the points
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            return int.Parse(_points) + _bonus;
        }
        else
        {
            return int.Parse(_points);
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target ? true : false;
    }

    public override string GetDetailsString()
    {
        return IsComplete() ? $"[X] {_shortname} ({_description}) -- Currently completed: {_amountCompleted}/{_target}" : $"[ ] {_shortname} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        //This method returns a string that makes easy to write and read the goal from a txt file.
        return $"SimpleGoal:{_shortname},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}