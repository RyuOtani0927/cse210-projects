// W08 Prove: Developer
// Ryu Otani

// Showing Creativity and Exceeding Requirements
// - Same prompts/questions will not be selected until they have all been used at least once in that session.



using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
    

        Program.Menu();

    }

    static void Menu()
    {
        int choice = 0;

        while (choice != 4){

            Console.Clear();

            Console.WriteLine();

            Console.WriteLine("Menu Option:");
            Console.WriteLine("     1. Start breathing activity");
            Console.WriteLine("     2. Start reflecting activity");
            Console.WriteLine("     3. Start listing activity");
            Console.WriteLine("     4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            
            if (choice == 1)
            {
                BreathingActivity activity = new BreathingActivity();
                activity.StartBreathing();
            } 
            else if (choice == 2)
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.StartReflection();
            }
            else if (choice == 3)
            {
                ListingActivity activity = new ListingActivity();
                activity.StartListing();
            }


        }
    }
}