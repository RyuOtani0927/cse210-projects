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

            Console.WriteLine("Menu Option:");
            Console.WriteLine("     1. Start breathing activity");
            Console.WriteLine("     2. Start reflecting activity");
            Console.WriteLine("     3. Start listing activity");
            Console.WriteLine("     4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            do
            {
                if (choice == 1)
                {
                    BreathingActivity activity = new BreathingActivity();
                    activity.DisplayStart();
                    activity.DisplayEnd();
                } 
                else if (choice == 2)
                {
                    ReflectionActivity activity = new ReflectionActivity();
                    activity.DisplayStart();
                    activity.DisplayEnd();
                }
                else if (choice == 3)
                {
                    ListingActivity activity = new ListingActivity();
                    activity.DisplayStart();
                    activity.DisplayEnd();
                }
                else if (choice != 4)
                {
                    Console.Write("Select a choice from the menu: ");
                    choice = int.Parse(Console.ReadLine());
                }
            } while ((choice < 1) || (choice > 4));


        }
    }
}