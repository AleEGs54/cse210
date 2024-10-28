public class GoalManager
{
    //Attributes
    private List<Goal> _goals = new List<Goal>();
    protected int _score;

    //Constructor
    public GoalManager()
    {
        _score = 0; // The player starts with 0 points.
    }

    //Methods
    public void Start()
    {
        int userInput = 0;

        while (userInput != 6)
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit\n");
            Console.Write("Select a choice from the menu: ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                CreateGoal();
            }
            else if (userInput == 2)
            {
                ListGoalDetails();
            }
            else if (userInput == 3)
            {
                SaveGoals();
            }
            else if (userInput == 4)
            {
                LoadGoals();
            }
            else if (userInput == 5)
            {
                RecordEvent();
            }
            else if (userInput == 6)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                //Return to the loop is it's an invalid number
                Console.WriteLine("That's not a valid number!\n");
                continue;
            }

        }

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }
    public void ListGoalNames()
    {
        //ListGoalNames is useful to only show the name but not the entire description of if, for example, when the user wants to record an event it will display the events but not their entire information. N. 5.
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetShortName()}");
            i++;
        }

    }
    public void ListGoalDetails()
    {
        //ListGoalDetails is useful to show the entire description of if, for example, when the user wants to know each detail about their goals. N. 2
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i++;
        }

    }
    public void CreateGoal()
    {
        string goal;
        string description;
        string points;
        int target;
        int bonus;


        Console.WriteLine("The types of goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal\n");
        Console.Write("Which type of goal would you like to create? ");

        int userInput = int.Parse(Console.ReadLine());

        if (userInput == 1)
        {
            Console.Write("\nWhat is the name of your goal? ");
            goal = Console.ReadLine();
            Console.Write("\nWhat is a short description of it? ");
            description = Console.ReadLine();
            Console.Write("\nWhat is the amount of points associated with this goal? ");
            points = Console.ReadLine();

            SimpleGoal simpleGoal = new SimpleGoal(goal, description, points);

            //Adding the goal to the list
            _goals.Add(simpleGoal);
        }
        else if (userInput == 2)
        {
            Console.Write("\nWhat is the name of your goal? ");
            goal = Console.ReadLine();
            Console.Write("\nWhat is a short description of it? ");
            description = Console.ReadLine();
            Console.Write("\nWhat is the amount of points associated with this goal? ");
            points = Console.ReadLine();

            EternalGoal eternalGoal = new EternalGoal(goal, description, points);

            //Adding the goal to the list
            _goals.Add(eternalGoal);
        }
        else if (userInput == 3)
        {
            Console.Write("\nWhat is the name of your goal? ");
            goal = Console.ReadLine();
            Console.Write("\nWhat is a short description of it? ");
            description = Console.ReadLine();
            Console.Write("\nWhat is the amount of points associated with this goal? ");
            points = Console.ReadLine();
            Console.Write("\nHow many times does this goal need to be accomplished for a bonus? ");
            target = int.Parse(Console.ReadLine());
            Console.Write("\nWhat is the bonus for accomplishing it that many times? ");
            bonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklistGoal = new ChecklistGoal(goal, description, points, target, bonus);

            //Adding the goal to the list
            _goals.Add(checklistGoal);
        }

    }
    public void RecordEvent()
    {
        //Calls the RecordEvent function from each goal in the list to add points to the player's score.

        ListGoalNames();
        Console.Write("\nWhich goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());

        //Receives the points associated with the chosen goal
        int points = _goals[choice - 1].RecordEvent();

        //Adds the points to the player's total score
        _score += points;

        Console.WriteLine($"\nCongratulations! You have earned {points} points!\n");
        Console.WriteLine($"You now have {_score} points.\n");
    }
    public void SaveGoals()
    {

    }
    public void LoadGoals()
    {

    }

}