using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

abstract class Activity
{
    protected string Name;
    protected string Description;
    protected int Duration;

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void GetDuration()
    {
        Console.Write("Enter duration in seconds: ");
        while (!int.TryParse(Console.ReadLine(), out Duration) || Duration <= 0)
        {
            Console.Write("Invalid input. Please enter a positive number: ");
        }
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\rStarting in {i}...");
            Thread.Sleep(1000);
        }
        Console.Write("\r ");
    }

    public void Start()
    {
        Console.WriteLine($"\nStarting {Name} Activity!");
        Console.WriteLine(Description);
        GetDuration();
        Console.WriteLine("Get ready...");
        Countdown(3);
        Run();
        End();
    }

    protected abstract void Run();

    protected void End()
    {
        Console.WriteLine("\nWell done!");
        Thread.Sleep(2000);
        Console.WriteLine($"You have completed the {Name} Activity for {Duration} seconds.");
        Thread.Sleep(3000);
    }
}