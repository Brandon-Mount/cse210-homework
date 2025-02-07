class ReflectionActivity : Activity
{
    private static readonly string[] Prompts =
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private static readonly string[] Questions =
    {
        "Why was this experience meaningful to you?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different?",
        "What is your favorite thing about this experience?",
        "What did you learn from this experience?"
    };

    public ReflectionActivity() : base("Reflection", "This activity helps you reflect on times of strength and resilience.") { }

    protected override void Run()
    {
        Console.WriteLine(Prompts[new Random().Next(Prompts.Length)]);
        Thread.Sleep(2000);
        int elapsed = 0;
        while (elapsed < Duration)
        {
            Console.WriteLine(Questions[new Random().Next(Questions.Length)]);
            Thread.Sleep(4000);
            elapsed += 4;
        }
    }
}