public class Job {

    //Atributtes
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    //Methods
    public void DisplayJobDetails() {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}");
    }
    //the variables will be reached when the specific object (like job1 or job2) calls the function. In other words, you dont need to do anything else than refere to general variables within your class while creating the function, because the object with these attributes will give these same attributes to let the function work.

}