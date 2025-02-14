class User
{
    public string Name { get; set; }
    public List<Goal> Goals { get; set; }
    public int Score { get; set; }

    private const string SaveFile = "progress.txt"; // Plain text file for saving progress

    public User(string name)
    {
        Name = name;
        Goals = new List<Goal>();
        Score = 0;
    }

    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < Goals.Count)
        {
            Score += Goals[goalIndex].RecordEvent();
        }
    }

    public void ShowGoals()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < Goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Goals[i].GetStatus()}");
        }
        Console.WriteLine($"Total Score: {Score}\n");
    }

    public void SaveProgress()
    {
        using (StreamWriter writer = new StreamWriter(SaveFile))
        {
            writer.WriteLine(Name);
            writer.WriteLine(Score);
            foreach (var goal in Goals)
            {
                writer.WriteLine(goal.SaveData());
            }
        }
    }

    public static User LoadProgress()
    {
        if (!File.Exists(SaveFile))
            return new User("Default User");

        using (StreamReader reader = new StreamReader(SaveFile))
        {
            string name = reader.ReadLine();
            int score = int.Parse(reader.ReadLine());
            User user = new User(name) { Score = score };

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                switch (parts[0])
                {
                    case "Simple":
                        user.Goals.Add(new SimpleGoal(parts[1], int.Parse(parts[2]), bool.Parse(parts[3])));
                        break;
                    case "Eternal":
                        user.Goals.Add(new EternalGoal(parts[1], int.Parse(parts[2]), int.Parse(parts[3])));
                        break;
                    case "Checklist":
                        user.Goals.Add(new ChecklistGoal(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5])));
                        break;
                }
            }

            return user;
        }
    }
}