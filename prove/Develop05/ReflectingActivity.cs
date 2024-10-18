public class ReflectingActivity : Activity{
    //Attributes
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    //Constructor
    public ReflectingActivity(string name, string description) : base(name, description)
    {

    }

    //Methods
    public void Run(){

    }
    public string GetRandomPrompt(){
        return "";
    }

    public string GetRandomQuestion(){
        return "";
    }

    public void DisplayPrompt(){

    }

    public void DisplayQuestions(){
        
    }
}