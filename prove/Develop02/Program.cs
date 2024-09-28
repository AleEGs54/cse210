using System;
using System.IO;
//author: Alejandro Esteves
//Exceeding requirements: Adding try-catch handler exceptions to avoid the program to suddenly crash, adding the capacity to register your emotion in the moment,
//adding a warning to the user - if he loads without saving, the current entries will be lost.

class Program
{
    static void Main(string[] args)
    {
        int userInput = 0;

        Console.WriteLine("Welcome to the Journal Program!");

        //Inicializar la clase Journal fuera para que no se reinicie en el bucle
        Journal journal = new Journal();

        while (userInput != 5)
        {
            try
            {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            userInput = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            
            if (userInput == 1)
            {

                
                //Creando una nueva instancia de la clase Entry
                Entry newEntry = new Entry();

                //Llamando al metodo AddEntry de la clase Journal para agregar una nueva entrada
                journal.AddEntry(newEntry);

            }
            else if (userInput == 2)
            {
                //journal llama al metodo DisplayAll() para imprimir Todas las interacciones
                journal.DisplayAll();
            }

            else if (userInput == 3)
            {
                //Code to Load

                //Recordatorio de que al cargar una nueva interaccion, la actual se borrará si no se ha guardado
                Console.WriteLine("Are you sure? Remember that your current sesion will be deleted if you don't save your entries... (Type Yes or No)");
                string desicion = Console.ReadLine();

                //Tomando la desición
                if (desicion.ToLower() == "yes") {
                //Almacenando el archivo csv en una variable
                Console.WriteLine("What is the filename? ");
                string fileName = Console.ReadLine();

                //Calling the LoadFromFile method from the Journal class and journal instance
                journal.LoadFromFile(fileName);
                }
                else if (desicion.ToLower() == "no")
                {
                    continue;
                }
                else {
                    Console.WriteLine("That's not a valid answer... try again later");
                }
                
            }
        
            else if (userInput == 4)
            {
                //Code to Save
                //Creating a file
                Console.WriteLine("What is the filename? (If the file doesn't exist in your directory, a new one will be created with that name)\n");
                string fileName = Console.ReadLine();
                //Calling the SaveToFile method from the Journal class and journal instance
                journal.SaveToFile(fileName);
            }
            else if (userInput == 5)
            {
                Console.WriteLine("\nThanks for using the Journal Program!");
            }

            else {
                //code here - that's not a valid number
                Console.WriteLine("That's not a valid number");
            }
            }
            //Would a user type anything else tha numbers?... yes, probably
            catch (FormatException){
                Console.WriteLine("That's not a number!");
            }
        }
    }
}                           