class ListingActivity : Activity
{
    private static readonly string[] Prompts =
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity helps you reflect by listing positive aspects of your life.") { }

    protected override void Run()
    {
        Console.WriteLine(Prompts[new Random().Next(Prompts.Length)]);
        Countdown(3);
        List<string> items = new List<string>();
        var startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < Duration)
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item);
            }
        }
        Console.WriteLine($"You listed {items.Count} items!");
    }
}
