public class Resume {
    public string _name;

    //creating a list with variable type = Job and variable name = jobs and initializing
    public List<Job> _jobs = new List<Job>();

    public void Display (){
        //Prints the name
        Console.WriteLine($"Name: {_name}");
        //Prints the job
        Console.WriteLine($"Jobs:");
        //Creates a loop that iterates 'list's lenght' times. It calls a function from the Job class which prints information about the jobs.
        for (int i = 0; i < _jobs.Count; i++) {
            _jobs[i].DisplayJobDetails();
            // nameOfList[job instance in the list (0,1,2...)].Function();
        }
    }
}