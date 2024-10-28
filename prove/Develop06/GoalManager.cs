using System.IO;

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
            DisplayMotivationalQuote();
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
        Console.Write("\nWhat is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename, false))
        {
            //false overwrites the file and removes the need to clear the file first.

            // Write the score to the file
            outputFile.WriteLine(_score);

            // Write the goals to the file
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("\nWhat is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        // Read the score from the file
        _score = int.Parse(lines[0]);

        // Read the goals from the file
        for (int i = 1; i < lines.Length; i++)
        {
            //Retrieving the object type from the string
            string[] preLine = lines[i].Split(':'); //This splits the string in two parts, the object type and the rest of the string. Is a preparatory array.

            string objectType = preLine[0];//Storing the Object Type

            string[] parts = preLine[1].Split(','); //Storing the rest of the string in an array and splitting it in parts

            if (objectType == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(parts[0], parts[1], parts[2], bool.Parse(parts[3]));
                _goals.Add(simpleGoal);
            }
            else if (objectType == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(parts[0], parts[1], parts[2]);
                _goals.Add(eternalGoal);
            }
            else if (objectType == "ChecklistGoal")
            {
                ChecklistGoal checklistGoal = new ChecklistGoal(parts[0], parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                _goals.Add(checklistGoal);
            }
        }
    }

    public void DisplayMotivationalQuote()
    {
        // Create a list of motivational quotes
        string[] quotes = new string[]
{
    "Believe you can and you're halfway there. - Theodore Roosevelt",
    "It does not matter how slowly you go as long as you do not stop. - Confucius",
    "Success is not final, failure is not fatal: It is the courage to continue that counts. - Winston Churchill",
    "Don't watch the clock; do what it does. Keep going. - Sam Levenson",
    "You miss 100% of the shots you don't take. - Wayne Gretzky",
    "I have not failed. I've just found 10,000 ways that won't work. - Thomas Edison",
    "You are never too old to set another goal or to dream a new dream. - C.S. Lewis",
    "The only way to do great work is to love what you do. - Steve Jobs",
    "Keep your eyes on the stars, and your feet on the ground. - Theodore Roosevelt",
    "You don't have to be great to start, but you have to start to be great. - Zig Ziglar",
    "Do something today that your future self will thank you for. - Unknown",
    "Happiness is not something ready made. It comes from your own actions. - Dalai Lama",
    "You are stronger than you seem, braver than you believe, and smarter than you think. - Christopher Robin",
    "The best way to predict your future is to create it. - Abraham Lincoln",
    "You don't have to control your thoughts. You just have to stop letting them control you. - Dan Millman",
    "The greatest glory in living lies not in never falling, but in rising every time we fall. - Nelson Mandela",
    "Do not let what you cannot do interfere with what you can do. - John Wooden",
    "You are never too young to start achieving your goals. - Unknown",
    "The only limit to our realization of tomorrow will be our doubts of today. - Franklin D. Roosevelt",
    "You don't have to be perfect to be amazing. - Unknown",
    "The best revenge is massive success. - Frank Sinatra",
    "You are capable of amazing things. - Unknown",
    "The future belongs to those who believe in the beauty of their dreams. - Eleanor Roosevelt",
    "You are the architect of your own destiny. - Unknown",
    "The only person you are destined to become is the person you decide to be. - Ralph Waldo Emerson",
    "Your time is limited, so don't waste it living someone else's life. - Steve Jobs",
    "The biggest risk is not taking any risk. - Mark Zuckerberg",
    "You miss 100% of the chances you don't take. - Wayne Gretzky",
    "I don't count my sit-ups. I only start counting when it starts burning. - Muhammad Ali",
    "You don't have to be a great singer to sing a great song. - Unknown",
    "The only way to get started is to quit talking and begin doing. - Walt Disney",
    "You are never too old to become younger. - Mae West",
    "The greatest wealth is health. - Virgil",
    "You are the master of your own destiny. - Unknown",
    "The biggest adventure you can take is to live the life of your dreams. - Oprah Winfrey",
    "You are stronger than you think, braver than you think, and smarter than you think. - Unknown",
    "The only person you need to be better than is the person you were yesterday. - Unknown",
    "You don't have to be a genius to be successful. - Unknown",
    "The only limit to our realization of tomorrow will be our doubts of today. - Franklin D. Roosevelt",
    "You are capable of achieving greatness. - Unknown",
    "The future is not something we enter, but something we create. - John Schaar",
    "You are the architect of your own happiness. - Unknown",
    "The only person you need to be is the best version of yourself. - Unknown",
    "You don't have to be a superhero to make a difference. - Unknown",
    "The biggest risk is not taking any risk. - Mark Zuckerberg",
    "You are the master of your own fate. - Unknown",
    "The only way to get what you want is to deserve it. - Theodore Roosevelt",
    "You are capable of achieving anything you set your mind to. - Unknown",
    "The future belongs to those who believe in the beauty of their dreams. - Eleanor Roosevelt",
    "You are the only person you need to be better than. - Unknown"
};

        // Create a random number generator
        Random random = new Random();

        // Display a random quote
        int quoteIndex = random.Next(quotes.Length);
        Console.WriteLine("\n" + quotes[quoteIndex] + "\n");
    }

}
