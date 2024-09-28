using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput = 0;

        Console.WriteLine("Welcome to the Journal Program!");

        while (userInput != 5)
        {
            
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write\n2. Display\n3.Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            userInput = int.Parse(Console.ReadLine());
            
            if (userInput == 1)
            {

                //1. Primero se genera un prompt
                PromptGenerator newPrompt = new PromptGenerator();

                //Creando Prompts manualmente
                newPrompt._prompts.Add("Que fue lo mas interesante que te pasó hoy? \n");
                newPrompt._prompts.Add("Quien hizo una diferencia en tu día? \n");
                newPrompt._prompts.Add("Cómo viste la mano de Dios el día de hoy? \n");
                newPrompt._prompts.Add("Cuál es un aspecto que debes de mejorar en el transcurso del día? \n");
                newPrompt._prompts.Add("Cuando la pasaste bien/mal? \n");

                //Almacenando el prompt que se eligió aleatoriamente
                string thePrompt = newPrompt.GetRandomPrompt();
                //Imprimiendo el prompt en la consola
                Console.WriteLine(thePrompt);

                //2. Luego se da espacio para que el usuario escriba la respuesta
                //Creando una nueva instancia de la clase Entry
                Entry newEntry = new Entry();

                //Almacenando el prompt en la instancia
                newEntry._promptText = thePrompt;
                //Almacenar la respuesta del usuario
                newEntry._entryText = Console.ReadLine();
                //3. Se guarda junto con la fecha actual
                //Creando una instancia de la clase DateTime
                DateTime theCurrentTime = DateTime.Now;
                //Almacenando la fecha actual y corta en la instancia de Entry
                newEntry._date = theCurrentTime.ToShortDateString();
                
                //4.Almacenando TODA la instancia en la lista del tipo Entry
                //Creando una instancia de la clase Journal para acceder a la lista _entries
                Journal journal = new Journal();
                //La entrada es finalmente almacenada en una lista de su tipo
                journal._entries.Add(newEntry);


                //8. Mostrando el resultado con la funcion de entry - por ahora servirá de prueba
                // newEntry.Display();


            }
            else if (userInput == 2)
            {
                //code here
            }

            else if (userInput == 3)
            {
                //code here
            }
        
            else if (userInput == 4)
            {
                //code here
            }
            else if (userInput == 5)
            {
                //code here thanks and bye
            }

            else {
                //code here - that's not a valid number
            }
        }
    }
}                           