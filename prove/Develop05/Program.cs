//Author: Alejandro Esteves
//Exceeding Requirements: Keeping a log of how many times activities were performed and displaying a number when the user finishes the program.

using System;

class Program
{
    static void Main(string[] args)
    {
        int activitiesDone = 0;
        int userInput = 0;

        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();

        while (userInput != 4)
        {
            //Displaying the options to the user
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("    1. Start breathing activity\n    2. Start reflecting activity\n    3. Start listing activity\n    4. Quit\n");
            Console.Write("Select a choice from the menu: ");

            //Asking for input and parsing to int
            userInput = int.Parse(Console.ReadLine());

            if  (userInput == 1){

                breathingActivity.Run();
                activitiesDone++;
                }
            else if  (userInput == 2){
                reflectingActivity.Run();
                activitiesDone++;
            }
            else if  (userInput == 3){
                listingActivity.Run();
                activitiesDone++;
            }
            else if (userInput == 4)
            {
                string summary = (activitiesDone == 0)? $"You did {activitiesDone} activities today. You can do it even better, I know it!" : $"Thanks for choosing us! You did {activitiesDone} activities today. Good Job!";
                Console.WriteLine(summary);
            }
            else {
                Console.WriteLine("That's not a valid option");
            }
        }

        
        
    }
}