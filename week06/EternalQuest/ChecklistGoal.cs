class ChecklistGoal : Goal
{
    private int Target;
    private int Count;
    private int Bonus;

    public ChecklistGoal(string name, int points, int target, int count = 0, int bonus = 0) : base(name, points)
    {
        Target = target;
        Count = count;
        Bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (Count < Target)
        {
            Count++;
            return Points + (Count == Target ? Bonus : 0);
        }
        return 0;
    }

    public override string GetStatus()
    {
        return $"[{(Count >= Target ? "X" : " ")}] {Name} - Completed {Count}/{Target} times";
    }

    public override string SaveData()
    {
        return $"Checklist|{Name}|{Points}|{Target}|{Count}|{Bonus}";
    }
}