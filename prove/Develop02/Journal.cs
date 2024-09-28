using System.ComponentModel;

public class Journal
{
    /*Una lista de tipo Entry implica que tiene acceso a las variables de su clase 
    y por lo tanto cuando es creada una instancia de esta lista, puedes acceder a sus variables
    declaradas en su propio documento de c# (Entry.cs)
    
    Esta lista tiene la capacidad del almacenar variables tipo Entry, que quiere decir
    que su funcion es almacenar toda la informacion que venga tras crear una instancia de
    Entry tras otra, cada una siendo unica*/
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {

                /*1. Primero se genera una instancia de la clase prompt, 
                para así acceder a su método GetRandomPrompt*/
                PromptGenerator newPrompt = new PromptGenerator();


                //Almacenando el prompt que se eligió aleatoriamente
                string thePrompt = newPrompt.GetRandomPrompt();
                //Imprimiendo el prompt en la consola
                Console.WriteLine(thePrompt);

                // /Almacenando el prompt en la instancia
                newEntry._promptText = thePrompt;
                //2. Luego se da espacio para que el usuario escriba la respuesta
                //Almacenar la respuesta del usuario
                newEntry._entryText = Console.ReadLine();

                //Almacenar la emoción
                Console.WriteLine("How do you feel right now?");
                newEntry._emotion = Console.ReadLine();
                //Dejando una linea por espaciado
                Console.WriteLine();
                //3. Se guarda junto con la fecha actual
                //Creando una instancia de la clase DateTime
                DateTime theCurrentTime = DateTime.Now;
                //Almacenando la fecha actual y corta en la instancia de Entry
                newEntry._date = theCurrentTime.ToShortDateString();

                /*Almacena la variable o instancia de Entry con la información codificada,
                Lista para ser leida por Display(), el cual es el trabajo
                de DisplayAll*/
                _entries.Add(newEntry);

                
    }

    public void DisplayAll()
    {

        /*Itera sobre todos los elementos Entry que estén en la lista y llama Display para que los junte en un
         solo string y los vaya imprimiendo en la consola*/
         //Por cada entrada de tipo Entry en la lista _entries...

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }

    }

    public void SaveToFile(string file)
{
    // Leer las líneas existentes del archivo para evitar duplicados
    List<string> existingEntries = new List<string>();
    if (File.Exists(file))
    {
        existingEntries.AddRange(File.ReadAllLines(file));
    }

    // Abrir el archivo en modo append
    using (StreamWriter outputFile = new StreamWriter(file, true))
    {
        // Por cada entrada en la lista _entries
        foreach (Entry entry in _entries)
        {
            // Formatear la entrada en el mismo formato que se guarda
            string formattedEntry = $"{entry._date}-{entry._promptText}-{entry._entryText}-{entry._emotion}";

            // Solo guardar la entrada si no está ya en el archivo
            if (!existingEntries.Contains(formattedEntry))
            {
                outputFile.WriteLine(formattedEntry);
            }
        }
    }
    Console.WriteLine($"\nEntries successfully saved to {file}.\n");
}

    public void LoadFromFile(string file) 
    {

        try
        {

        //Remover todo lo que esté en la lista actual para dar paso a una nueva interacción
        _entries.Clear();

        //Almacenando el contenido del csv en la lista String lines
        string[] lines = System.IO.File.ReadAllLines(file);

        

        //Iterando sobre cada linea de la lista lines
        foreach (string line in lines)
        {
            /*Creando una instancia de Entry para tener acceso a la lista
            _entries y agregar allí lo que esté en el csv*/
            Entry anotherEntry = new Entry();

            //Dividiendo la cadena de texto en 3 partes:   
            //_date-_promptText-_entryText
            //9/28/2024-Quien hizo una diferencia en tu día?-Mi familia
            string[] parts = line.Split("-");

            //Almacenando cada parte en la instancia anotherEntry
            anotherEntry._date = parts[0];
            anotherEntry._promptText = parts[1];
            anotherEntry._entryText = parts[2];
            anotherEntry._emotion = parts[3];
            
            //Agregando la instancia anotherEntry en la lista _entries (como si siempre hubiera estado allí).
            _entries.Add(anotherEntry);
        }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found. Please check the filename and try again.");
        }
    }
}