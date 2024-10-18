using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput = 0;
        
        BreathingActivity breathingActivity = new BreathingActivity();

        while (userInput != 4)
        {
            //Displaying the options to the user
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("    1. Start breathing activity\n    2.Start reflecting activity\n    3.Start listing activity\n    4.Quit\n");
            Console.Write("Select a choice from the menu: ");

            //Asking for input and parsing to int
            userInput = int.Parse(Console.ReadLine());

            if  (userInput == 1){

                breathingActivity.Run();
                }
            else if  (userInput == 2){}
            else if  (userInput == 3){}
            else {try{
                
            } catch{

            }}
        }

        
        
    }
}