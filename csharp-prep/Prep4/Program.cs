using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        //Creating a list
        List<int> listNumbers = new List<int>();


        int userInput = -1;
        float sum = 0;
        float count = 0;
        int largestNumber = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        while (userInput != 0)
        {
            Console.Write("Enter a number: ");
            userInput = int.Parse(Console.ReadLine());
            listNumbers.Add(userInput);

            if (userInput != 0)
                {
                    count += 1;
                }
            
        }

        foreach (int number in listNumbers)
        {
            //Calculating the sum
            sum += number;
            
            //Calculating the largest number
            

            if (largestNumber < number)
            {
                largestNumber = number;
            }

        }

        //Calculating the average
        float average = sum / count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");


    }
}