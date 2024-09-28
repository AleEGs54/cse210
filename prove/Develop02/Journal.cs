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

    }

    public void DisplayAll()
    {
        //This method displays all the entries that were saved and loaded and also calls the
        //entry display method so it also displays the information that was wrote but not saved
        //in that session.
    }

    public void SaveToFile(string file)
    {

    }

    public void LoadFromFile(string file) 
    {

    }
}