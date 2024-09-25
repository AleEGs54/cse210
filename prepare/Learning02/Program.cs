using System;

class Program
{
    static void Main(string[] args)
    {
        //Job1
        Job job1 = new Job();

        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // job1.DisplayJobDetails();

        //Job2
        Job job2 = new Job();

        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // job2.DisplayJobDetails();

        //Resume class
        Resume myresume = new Resume();

        myresume._name = "Alejandro Esteves";

        //Adding jobs to the list for the resume class
        myresume._jobs.Add(job1);
        myresume._jobs.Add(job2);

        // Console.WriteLine(myresume._jobs[0]._jobTitle);

        myresume.Display();
    }
}