using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Alejandro Esteves", "CSE210");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Joe Doe", "Math for the Real World", "Lesson 5", "Problems 5-12");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Martha Smith", "History", "Causes of the World War III");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}