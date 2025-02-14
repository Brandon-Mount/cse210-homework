using System;

class Program
{
    static void Main()
    {
        User user = User.LoadProgress(); // Load existing progress if available
        Console.WriteLine($"Welcome, {user.Name}!\n");

        while (true)
        {
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Record Goal Completion");
            Console.WriteLine("3. View Goals");
            Console.WriteLine("4. Save and Exit");
            Console.Write("Choose an option: ");
            
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Select goal type:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.Write("Enter choice: ");
                    string goalType = Console.ReadLine();

                    Console.Write("Enter goal name: ");
                    string goalName = Console.ReadLine();
                    Console.Write("Enter points: ");
                    int points = int.Parse(Console.ReadLine());

                    if (goalType == "1")
                    {
                        user.AddGoal(new SimpleGoal(goalName, points));
                    }
                    else if (goalType == "2")
                    {
                        user.AddGoal(new EternalGoal(goalName, points));
                    }
                    else if (goalType == "3")
                    {
                        Console.Write("Enter target count: ");
                        int target = int.Parse(Console.ReadLine());
                        Console.Write("Enter bonus points: ");
                        int bonus = int.Parse(Console.ReadLine());
                        user.AddGoal(new ChecklistGoal(goalName, points, target, 0, bonus));
                    }
                    Console.WriteLine("Goal added!\n");
                    break;

                case "2":
                    user.ShowGoals();
                    Console.Write("Enter goal number to mark as complete: ");
                    int goalIndex = int.Parse(Console.ReadLine()) - 1;
                    user.RecordEvent(goalIndex);
                    Console.WriteLine("Goal recorded!\n");
                    break;

                case "3":
                    user.ShowGoals();
                    break;

                case "4":
                    user.SaveProgress();
                    Console.WriteLine("Progress saved. Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid option. Try again.\n");
                    break;
            }
        }
    }
}