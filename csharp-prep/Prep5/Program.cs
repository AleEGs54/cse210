using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int result = SquareNumber(userNumber);
        
        DisplayResult(userName, result);

        //DisplayWelcome
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        //PromptUserName
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }
        //PromptUserNumber
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        //SquareNumber
        static int SquareNumber(int number)
        {
            int squareResult = number * number ;

            return squareResult;
        }

        //DisplayResult
        static void DisplayResult(string name, int squareNumber )
        {
            Console.WriteLine($"{name}, the square of your number is {squareNumber}");
        }


    }
}