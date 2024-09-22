using System;

class Program
{
    static void Main(string[] args)
    {

        // Asking the user for it's grade and parsing it to a number
        Console.Write("What is your grade percentage?");
        int grade = int.Parse(Console.ReadLine());

        //Creating a string variable to store the letter
        string letter = "";

        //printing the letter according to the grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        //Printing the letter variable
        Console.WriteLine($"Your grade is: {letter}");

        //Determining if the user passed the course or not
        if (grade >= 70)
        {
            Console.WriteLine("Well done! Keep the hard work");
        }
        else
        {
            Console.WriteLine("Come on, you can do it even better, I know it!");
        }
    }
}