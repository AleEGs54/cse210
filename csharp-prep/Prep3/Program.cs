using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {

        string userInput;

        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1,101);

        Console.WriteLine("Guess the magic number! ");

        do
        {
            Console.Write("What is your guess? ");
            userInput = Console.ReadLine();

            if (int.Parse(userInput) < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (int.Parse(userInput) > magicNumber)
            {
                Console.WriteLine("lower");
            }

        } while (int.Parse(userInput) != magicNumber);

        Console.WriteLine("You guessed it!");

    }
}
