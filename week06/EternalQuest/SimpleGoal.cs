class SimpleGoal : Goal
{
    private bool Completed;

    public SimpleGoal(string name, int points, bool completed = false) : base(name, points)
    {
        Completed = completed;
    }

    public override int RecordEvent()
    {
        if (!Completed)
        {
            Completed = true;
            return Points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        return Completed ? $"[X] {Name}" : $"[ ] {Name}";
    }

    public override string SaveData()
    {
        return $"Simple|{Name}|{Points}|{Completed}";
    }
}