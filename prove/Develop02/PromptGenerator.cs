public class PromptGenerator
{
    public List<string> _prompts = new List<string>();


    public string GetRandomPrompt()
    {
        /*Creando prompts manualmente*/

        _prompts.Add("What was the most interesting thing that happened to you today?");
        _prompts.Add("Who made a difference in your day?");
        _prompts.Add("How did you see God's hand in your day today?");
        _prompts.Add("What is one area you should improve on during the day?");
        _prompts.Add("When did you have a good/bad time?");
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        
        /*Esta funcion crea una instancia de la clase Random,
        almacena un numero del 0 al 4 (excluye 5) en una variable
        y usa ese numero como índice de la lista _prompts, la
        cual contiene 5 prompts que se crearon manualmente en la clase main
        y retorna el prompt en un string */

        Random random = new Random();
        int randomNumber = random.Next(0, _prompts.Count());

        string prompt = _prompts[randomNumber];
        return prompt;
    }
}