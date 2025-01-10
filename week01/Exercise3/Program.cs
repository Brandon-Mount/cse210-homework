using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

       // here we will get a random number between 1 and 100
         Random random = new Random();
         int magicNumber = random.Next(1, 101);

         int guess = 0;

            while (guess != magicNumber)
            {
                Console.WriteLine("Guess the magic number between 1 and 100: ");
                guess = int.Parse(Console.ReadLine());
    
                if (guess < magicNumber)
                {
                    Console.WriteLine("The magic number is greater than your guess.");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("The magic number is less than your guess.");
                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed the magic number!");
                }
            }



    }
}