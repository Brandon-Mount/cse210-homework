class EternalGoal : Goal
{
    private int Count;

    public EternalGoal(string name, int points, int count = 0) : base(name, points)
    {
        Count = count;
    }

    public override int RecordEvent()
    {
        Count++;
        return Points;
    }

    public override string GetStatus()
    {
        return $"[∞] {Name} - Completed {Count} times";
    }

    public override string SaveData()
    {
        return $"Eternal|{Name}|{Points}|{Count}";
    }
}