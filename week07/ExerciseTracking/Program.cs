using System;

class Program
{
    static void Main()
    {
        // Create a list of activities
        List<Activity> activities = new List<Activity>
        {
            new Running(30, 3.0),  // 30 minutes, 3 miles
            new Cycling(60, 20.0),  // 60 minutes, 20 miles
            new Swimming(45, 30)    // 45 minutes, 30 laps
        };

        // Iterate through the list and print summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}