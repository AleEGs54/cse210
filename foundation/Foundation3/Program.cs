using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(30,3);

        Cycling cycling = new Cycling(20,15);

        Swimming swimming = new Swimming(30,20);

        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }

    }
}