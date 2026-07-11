using System;

//To Add creativity and exceed requirements I added a variable of mood so users can also keep track of they are feeling each day.
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator prompts = new PromptGenerator();
        int choice = 1;

        while (choice != 5)
        {
            Console.WriteLine("1 Write");
            Console.WriteLine("2 Display");
            Console.WriteLine("3 Load");
            Console.WriteLine("4 Save");
            Console.WriteLine("5 Quit");
            Console.WriteLine("What would you like to do?");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("How are you feeling today? ");
                Console.Write("(Happy, Okay, Sad, Irritated, Tired)");
                string mood = Console.ReadLine();

                string prompt = prompts.GetRandomPrompt();
                Console.WriteLine(prompt);

                string entryText = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                Entry entry = new Entry();
                entry._date = dateText;
                entry._mood = mood;
                entry._promptText = prompt;
                entry._entryText = entryText;

                journal.AddEntry(entry);
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.WriteLine("What file would you like to load?");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == 4)
            {
                Console.WriteLine("What file would you like to save it to?");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
        }
    }
}