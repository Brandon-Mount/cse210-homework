using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.WriteLine("What is your grade percentage?");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);
        
        // This if/else statement will determine the letter grade based on the user's input.

        string gradeLetter;

        if (grade >= 90)
        {
            //Console.WriteLine("You got an A!");
            gradeLetter = "A";
        }
        else if (grade >= 80)
        {
            //Console.WriteLine("You got a B!");
            gradeLetter = "B";
        }
        else if (grade >= 70)
        {
            //Console.WriteLine("You got a C!");
            gradeLetter = "C";
        }
        else if (grade >= 60)
        {
            //Console.WriteLine("You got a D!");
            gradeLetter = "D";
        }
        else
        {
            //Console.WriteLine("You got an F!");
            gradeLetter = "F";
        }

        Console.WriteLine($"You got a {gradeLetter}!");

    // This if/else statement will congratulate the user based on their grade percentage.

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("I'm sorry, you did not pass the class.");
        }
    }
}