public class ReflectingActivity : Activity{
    //Attributes
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    //Constructor
    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on time in your life when you have shown strenght and resilience. This activity will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    //Methods
    public void Run(){

        //Starting to run the program
        DisplayStartingMessage();
        Console.WriteLine("\nConsider the following prompt:\n");
        DisplayPrompt();
        Console.WriteLine("\nWhen you have something in mind press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Console.Write("You may begin in: "); ShowCountDown(5);

        //Clearing the console to write more...
        Console.Clear();

        //Converting _duration(int) to double to use the Round function if the user sets duration as a number not a multiple of 15. (i.e. 24, 33, 56, 12, 11, etc)
        double doubleDuration = _duration;

        //Away from zero helps to handle situations with the number 5...
        double numberOFIterations = Math.Round(doubleDuration / 15, 0, MidpointRounding.AwayFromZero);

        for (double i = numberOFIterations; i > 0; i--)
        {
            DisplayQuestions();
        }
        
        DisplayEndingMessage();

    }
    public string GetRandomPrompt(){
        //Creating a list of prompts
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        //Selecting a random prompt and returning it.
        Random random = new Random();
        int randomNumber = random.Next(0,4);

        return _prompts[randomNumber];
    }

    public string GetRandomQuestion(){
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        Random random = new Random();
        int randomNumber = random.Next(0,9);

        return _questions[randomNumber];
    }

    public void DisplayPrompt(){
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }
 
    public void DisplayQuestions(){
        Console.Write($"> {GetRandomQuestion()} "); ShowSpinner(15);
        Console.WriteLine();
    }
}