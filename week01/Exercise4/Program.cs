using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

       // Create a list to store the numbers
        List<int> numbers = new List<int>();

        // Ask the user to enter numbers
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;

        // Loop to get the numbers from the user
        do
        {
            Console.Write("Enter number: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);

        // Compute the sum of the numbers
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        // Compute the average of the numbers
        double average = (double)sum / numbers.Count;

        // Find the maximum number
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        // Display the results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}