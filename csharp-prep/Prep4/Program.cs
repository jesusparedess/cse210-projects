using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

          List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            
            if (number == 0)
            {
                break;
            }

            numbers.Add(number);
        }

        int sum = 0;
        foreach (int number in numbers)
        {
        sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        double average = numbers.Count > 0 ? (double)sum / numbers.Count : 0;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");

    }
}