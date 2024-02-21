using System;

class Program
{
    public static void Main()
    {
        Address eventAddress1 = new Address("123 Central Park St", "Old York", "YN", "USA");
        Address eventAddress2 = new Address("456 Freedom Av", "Bos Town", "AM", "USA");
        Address eventAddress3 = new Address("Main Square", "Blue Beach", "LF", "USA");

        Event lecture = new LectureEvent("Lecture on Event Planning", "Learn about event planning.", DateTime.Today, new TimeSpan(18, 0, 0), eventAddress1, "Jane Doe", 100);
        Event reception = new ReceptionEvent("Annual Reception", "Join us for our annual reception.", DateTime.Today.AddDays(1), new TimeSpan(19, 30, 0), eventAddress2, "[email protected]");
        Event outdoor = new OutdoorEvent("Outdoor Concert", "Enjoy an evening of music.", DateTime.Today.AddDays(2), new TimeSpan(17, 0, 0), eventAddress3, "Sunny with a chance of showers");

        PrintEventDetails(lecture);
        Console.WriteLine("\n");
        PrintEventDetails(reception);
        Console.WriteLine("\n");
        PrintEventDetails(outdoor);
    }

    private static void PrintEventDetails(Event eventItem)
    {
        Console.WriteLine(eventItem.GetStandardDetails());

        Console.WriteLine(eventItem.GetFullDetails());

        Console.WriteLine(eventItem.GetShortDescription());
    }
}