using System;
using System.Diagnostics;
//Exceeding Requirements: A timer has been added to help the user measure how long it takes to memorize the scripture to motivate them to improve.
class Program
{
    static void Main(string[] args)
    {
        //First, create a Reference object otherwise, we wont have anything to fullfil as parameter
        Reference reference1 = new Reference(book: "Proverbs", chapter: 3, 5, 6);

        //Then, create a variable with the scriptur within
        string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        //Finally create a Scripture object
        Scripture scripture1 = new Scripture(Reference: reference1, text: scriptureText);

        Console.WriteLine(scripture1.GetDisplayText());
        Console.WriteLine("Press enter to continue or type 'quit' to finish");
        string userInput = Console.ReadLine();

        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();

        //Loop to stay in the program or close it
        while (scripture1.IsCompletelyHidden() != true)
        {

            //If the user types quit, the loop finishes and the program ends
            if (userInput == "quit")
            {
                break;
            }

            //Clearing the console
            Console.Clear();

            //Choosing how many words to hide
            scripture1.HideRandomWords(3);

            //Repeating the loop...
            Console.WriteLine(scripture1.GetDisplayText());

            //Showing the time it's taking to the user
            Console.WriteLine($"Time taken: {stopwatch.Elapsed.Seconds} seconds");

            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            userInput = Console.ReadLine();
        }

        //Final result in time
        stopwatch.Stop();
        Console.WriteLine($"Total time taken: {stopwatch.Elapsed.Seconds} seconds");

    }
}