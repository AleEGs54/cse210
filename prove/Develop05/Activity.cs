public class Activity
{
    //Attributes
    protected string _name;
    protected string _description;
    protected int _duration;

    //Cosntructor
    //Protecting the constructor so Program.cs dont access to it.
    protected Activity()
    {
        _name = "Default name of an activity";
        _description = "Generic description";
    }
    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;
        //Dont set the duration now, the user will set that value while program runs.
        // _duration = duration;
    }

    //Methods
    public void DisplayStartingMessage()
    {
        //Clearing the console
        Console.Clear();
        //Greeting and description
        Console.WriteLine($"\nWelcome to the {_name} \n\n{_description} \n\n");
        //Asking for duration
        Console.Write("How long, in seconds, would you like for your session? ");
        //Setting duration
        _duration = int.Parse(Console.ReadLine());

        //Clearing the console
        Console.Clear();

        //Get ready and displaying the spinner.
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\n\nWell done!! \nYou have completed another session of {_duration} seconds of the {_name}");
        Console.WriteLine("--------------------------------------------------------------------------");
    }

    public void ShowSpinner(int seconds)
    {
        //Creating the list with the sprites of the spinner animation
        List<string> animationStrings =
        [
            "|",
            "/",
            "-",
            "\\",
            "|",
            "/",
            "-",
            "\\",
        ];

        //This code adds 10 second to whatever the current time is.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        //This is a variable that will count each iteration
        int i = 0;

        //The while loop will iterate as long as "seconds" last
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            //The \b \b is like clicking on left arrow, then sets a blank space that erases the current sprite and finally clicking again on left arrow. (<-)
            Console.Write("\b \b");

            i++;

            //If there is no more sprites available after index 7, restart the animation
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }

    }

    public void ShowCountDown(int seconds)
    {
        //Creates a timer that lasts as long as "seconds" does
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }


}