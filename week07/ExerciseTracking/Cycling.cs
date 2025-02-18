class Cycling : Activity
{
    private double distanceMiles;

    public Cycling(int minutes, double distanceMiles) : base(minutes)
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