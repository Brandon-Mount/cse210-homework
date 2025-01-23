using System;

class Program
{
    static void Main(string[] args)
    {
        // Example with a single verse
        Scripture singleVerseScripture = new Scripture(
            "John", 3, 16, 
            "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life");

        // Example with a verse range
        Scripture verseRangeScripture = new Scripture(
            "Proverbs", 3, 5, 6, 
            "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths");

        // Choose which scripture to display and manipulate
        Scripture scripture = singleVerseScripture; // Or verseRangeScripture

        // Main loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.AreAllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden. Press Enter to exit.");
                Console.ReadLine();
                break;
            }

            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords();
        }
    }
}


