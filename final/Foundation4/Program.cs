using System;

class Program
{
    public static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2024, 1, 10), 30, 3.0),
            new Cycling(new DateTime(2024, 1, 25), 45, 15),
            new Swimming(new DateTime(2024, 2, 15), 30, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}