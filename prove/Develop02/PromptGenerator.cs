public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        /*Esta funcion crea una instancia de la clase Random,
        almacena un numero del 0 al 4 (excluye 5) en una variable
        y usa ese numero como índice de la lista _prompts, la
        cual contiene 5 prompts que se crearon manualmente en la clase main
        y retorna el prompt en un string */
        
        Random random = new Random();
        int randomNumber = random.Next(0, 5);

        string prompt = _prompts[randomNumber];
        return prompt;
    }
}