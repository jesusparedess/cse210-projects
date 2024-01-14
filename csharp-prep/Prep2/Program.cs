using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("Enter your grade percentage: ");
        double grade = double.Parse(Console.ReadLine());
        string letterGrade;
        string message;

        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your grade is: {letterGrade}");

        if (grade >= 70)
        {
            message = "Congratulations! You passed the class.";
        }
        else
        {
            message = "Im sorry! Try again.";
        }

        Console.WriteLine(message);

    }
}