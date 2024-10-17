using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        string response = "";
        while(response == "")
        {
        Reference reference = new Reference("Proverbs",3,5,6);
        Scripture scripture = new Scripture(reference,"Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge Him, and he shall direct thy path.");
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine(" ");
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        response = Console.ReadLine();
        Word word = new Word("Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge Him, and he shall direct thy path.");
        Console.Clear();
        Console.WriteLine(word.Ishidden());

        }


        

    }
}