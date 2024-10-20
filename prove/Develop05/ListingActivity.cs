using System.Diagnostics;

public class ListingActivity : Activity
{

    //Attributes
    private int _count;
    private List<string> _prompts = new List<string>();

    //Constructor
    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help yoy reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    //Methods
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        GetRandomPrompt();
        Console.Write("You may begin in: "); ShowCountDown(5);
        Console.WriteLine();
        List<string> aList = GetListFromUser();
        _count = aList.Count();
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
        
    }

    public void GetRandomPrompt()
    {
        //Creating a list of prompts
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        //Selecting a random prompt and returning it.
        Random random = new Random();
        int randomNumber = random.Next(0,4);

        Console.WriteLine(_prompts[randomNumber]);
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = [];

        Stopwatch stopwatch = new Stopwatch();

        //Start the stopwatch
        stopwatch.Start();

        //Allowing the user to make a list for the amount of time he decided.
        while (stopwatch.Elapsed.TotalSeconds < _duration)
        {
            string text = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(text))
            {
                userList.Add(text);
            }
        }

        return userList;
    }
}