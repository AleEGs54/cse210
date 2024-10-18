public class BreathingActivity : Activity
{
    //No attributes required

    //Constructor
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking through your breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    //Methods
    public void Run()
    {
        DisplayStartingMessage();

        //Preparatory breathe...
        Console.Write("\nBreathe in..."); ShowCountDown(2);
        Console.Write("\nNow breathe out..."); ShowCountDown(3);

        //Each breathe takes 10 second between each "in" and "out", so here I'm dividing the duration set by the user by a breathe (10 seconds), and that is the quantity of iterations the loop must do.

        //Converting _duration(int) to double to use the Round function if the user sets duration as a number not a multiple of 10. (i.e. 24, 33, 56, 12, 11, etc)
        double doubleDuration = _duration;

        //Away from zero helps to handle situations with the number 5...
        double numberOFIterations = Math.Round(doubleDuration / 10, 0, MidpointRounding.AwayFromZero);

        for (double i = numberOFIterations; i > 0; i--)
        {
            Console.Write("\n\nBreathe in..."); ShowCountDown(4);
            Console.Write("\nNow breathe out..."); ShowCountDown(6);
        }
        //Displaying the final message
        DisplayEndingMessage();
    }
}