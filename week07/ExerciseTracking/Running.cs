class Running : Activity
{
    private double distanceMiles;

    public Running(int minutes, double distanceMiles) : base(minutes)
    {
        this.distanceMiles = distanceMiles;
    }

    public override double GetDistance()
    {
        return distanceMiles;
    }

    public override double GetSpeed()
    {
        return (distanceMiles / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / distanceMiles;
    }
}