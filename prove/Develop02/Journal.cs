
public class Journal
{

    public List<Entry> entries = new();

    public void Write()
    {
        Entry entry = new();

        List<string> prompts = new();
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");

        Random rnd = new Random();
        int promptIndex = rnd.Next(prompts.Count);

        Console.WriteLine();

        entry.prompt = prompts[promptIndex];

        Console.WriteLine(entry.prompt);
        Console.Write("> ");
        entry.response = Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;
        entry.date = theCurrentTime.ToShortDateString();

        entries.Add(entry);

    }

    public void Display()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine();
            string arrangedEntry = entry.Arrange();
            Console.WriteLine(arrangedEntry);
        }
    }

    public void Save()
    {
        Console.WriteLine("Save");
    }

    public void Load()
    {
        Console.WriteLine("Load");
    }

    public void Menu()
    {
        int choice = 0;

        while (choice != 5)
        {
            choice = 0;

            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            while (choice < 1 || choice > 5)
            {
                Console.Write("What would you like to do? (1-5): ");
                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Write();
                }
                else if (choice == 2)
                {
                    Display();
                }
                else if (choice == 3)
                {
                    Save();
                }
                else if (choice == 4)
                {
                    Load();
                }
                else if (choice == 5)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Please type again.");
                    Console.WriteLine();
                }

            }
        }
    }
}