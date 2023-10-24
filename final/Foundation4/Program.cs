using System;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        List<Activity> activities = new List<Activity>();

        RunningActivity running = new RunningActivity(4.8f,"10 Dec in the Morning", 40);
        activities.Add(running);

        SwimmingActivity swimming = new SwimmingActivity(95,"18 Nov in the Morning", 27);
        activities.Add(swimming);

        CyclingActivity cycling = new CyclingActivity(7.6f,"30 Oct in the Morning", 50);
        activities.Add(cycling);

        foreach (Activity activity in activities)
        {
            System.Console.WriteLine(activity.GetAll());
        }


    }
}