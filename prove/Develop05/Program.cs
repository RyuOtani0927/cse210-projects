using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        Menu();
    }

    static void Menu()
    {
        List<Goal> goalsList = new();

        int choice = 0;
        while (choice != 6)
        {
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Create New Goal");
            Console.WriteLine("     2. List Goals");
            Console.WriteLine("     3. Save Goals");
            Console.WriteLine("     4. Load Goals");
            Console.WriteLine("     5. Record Event");
            Console.WriteLine("     6. Quit");
            
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                goalsList.Add(CreateGoal());
            }
            else if (choice == 2)
            {
                ListGoals(goalsList);
            }
            else if (choice == 3)
            {
                SaveGoals(goalsList);
            }
            else if (choice == 4)
            {
                LoadGoals(goalsList);
            }
            else if (choice == 5)
            {
                RecordEvent();
            }
            else if (choice != 6)
            {
                Console.WriteLine("Please Type Again.");
            }
        }
    }

    static Goal CreateGoal()
    {
        int goalChoice = 0;
        do
        {
            Console.WriteLine();
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("     1. Simple Goal");
            Console.WriteLine("     2. Eternal Goal");
            Console.WriteLine("     3. Checklist Goal");
            Console.Write("Which type of goal would you like to create?: ");
            goalChoice = int.Parse(Console.ReadLine());  

            if (goalChoice < 1 || goalChoice > 3)
            {
                Console.WriteLine("Please Type Again.");
            }
        } while (goalChoice < 1 || goalChoice > 3);
        
        

        Goal newGoal = new();

        if (goalChoice == 1)
        {
            newGoal = new SimpleGoal();
        }
        else if (goalChoice == 2)
        {
            newGoal = new EternalGoal();
        }
        else if (goalChoice == 3)
        {
            newGoal = new ChecklistGoal();
        }

        newGoal.CreateNewGoal();
        return newGoal;
    }
    static void ListGoals(List<Goal> goalsList)
    {
        for (int i = 0; i < goalsList.Count; i++)
        {
            Console.WriteLine($"    {i+1}. {goalsList[i].GetGoalDetail()}");
        }
    }
    static void SaveGoals(List<Goal> goalsList)
    {
        Console.Write("What is the filename for the goal file?: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Goal goal in goalsList)
            {
                outputFile.WriteLine(goal.FormatGoalLined());
            }
        }
    }
    static void LoadGoals(List<Goal> goalsList)
    {
        Console.Write("What is the filename for the goal file?: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        
        goalsList.Clear();

        foreach (string line in lines)
        {
            string goalType = line.Split(":")[0];

            string goalDetail = line.Split(":")[1];
            string[] goalInfos = goalDetail.Split("|");

            Goal loadedGoal = new();

            if (goalType == "SimpleGoal")
            {
                loadedGoal = new SimpleGoal(goalInfos);
            }
            else if (goalType == "EternalGoal")
            {
                loadedGoal = new EternalGoal(goalInfos);
            }
            else if (goalType == "ChecklistGoal")
            {
                loadedGoal = new ChecklistGoal(goalInfos);
            }

            goalsList.Add(loadedGoal);

        }
        

    }
    static void RecordEvent()
    {
        Console.WriteLine("RecordEvent");
    }
    static int GetTotalPoints()
    {
        return 0;
    }
}