//To add creativity. I added a text file called scriptures.txt with some scriptures and made my program read through the text file and randomly choose a scripture to display.

using System;

class Program
{
    static void Main(string[] args)
    {

        List<Scripture> scriptures = new List<Scripture>();
        Random random = new Random();

        string[] lines = File.ReadAllLines("scriptures.txt");

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            string book = parts[0];
            int chapter = int.Parse(parts[1]);
            int startVerse = int.Parse(parts[2]);
            string endVerseText = parts[3];
            string text = parts[4];

            Reference reference;

            if (string.IsNullOrWhiteSpace(endVerseText))
            {
                reference = new Reference(book, chapter, startVerse);
            }
            else
            {
                reference = new Reference(book, chapter, startVerse, int.Parse(endVerseText));
            }

            scriptures.Add(new Scripture(reference, text));
        }

        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            Console.Write("Press Enter to continue or type 'quit' to finish: ");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                return;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("All words are hidden.");
    }
}