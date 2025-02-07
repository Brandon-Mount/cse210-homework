class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by guiding you through slow breathing.") { }

    protected override void Run()
    {
        int elapsed = 0;
        while (elapsed < Duration)
        {
            Console.WriteLine("Breathe in...");
            Countdown(3);
            elapsed += 3;
            Console.WriteLine("Breathe out...");
            Countdown(3);
            elapsed += 3;
        }
    }
}