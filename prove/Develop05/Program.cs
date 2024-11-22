// Unit 05 Develop: Eternal Quest Program
// Ryu Otani

// Showing Creativity and Exceeding Requirements: 
// I added a new type of goal called "Negative Goal", where the user lose points for bad habits or when they fail the goal.


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
        int totalPoints = 0;

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

            if (choice == 6)
            {
                break;
            }
            else if (choice == 1)
            {
                goalsList.Add(CreateGoal());
            }
            else if (choice == 2)
            {
                ListGoals(goalsList);
            }
            else if (choice == 3)
            {
                SaveGoals(goalsList, totalPoints);
            }
            else if (choice == 4)
            {
                totalPoints = LoadGoals(goalsList,totalPoints);
            }
            else if (choice == 5)
            {
                totalPoints = RecordEvent(goalsList, totalPoints);
            }
            else
            {
                Console.WriteLine("Please Type Again.");
                continue;
            }

            Console.WriteLine();
            Console.WriteLine($"You have {totalPoints} points.");
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
            Console.WriteLine("     4. Negative Goal");
            Console.Write("Which type of goal would you like to create?: ");
            goalChoice = int.Parse(Console.ReadLine());  

            if (goalChoice < 1 || goalChoice > 4)
            {
                Console.WriteLine("Please Type Again.");
            }
        } while (goalChoice < 1 || goalChoice > 4);
        
        

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
        else if (goalChoice == 4)
        {
            newGoal = new NegativeGoal();
        }

        newGoal.CreateNewGoal();
        return newGoal;
    }
    static void ListGoals(List<Goal> goalsList)
    {
        Console.WriteLine();
        Console.WriteLine("The goals are:");
        for (int i = 0; i < goalsList.Count; i++)
        {
            Console.WriteLine($"    {i+1}. {goalsList[i].GetGoalDetail()}");
        }
    }
    static void SaveGoals(List<Goal> goalsList, int totalPoints)
    {
        Console.Write("What is the filename for the goal file?: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(totalPoints);

            foreach (Goal goal in goalsList)
            {
                outputFile.WriteLine(goal.FormatGoalLined());
            }
        }
    }
    static int LoadGoals(List<Goal> goalsList, int totalPoints)
    {
        Console.Write("What is the filename for the goal file?: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        totalPoints = int.Parse(lines[0]);

        lines = lines.Skip(1).ToArray();

        goalsList.Clear();

        foreach (string line in lines)
        {
            string goalType = line.Split("::")[0];

            string goalDetail = line.Split("::")[1];
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
            else if (goalType == "NegativeGoal")
            {
                loadedGoal = new NegativeGoal(goalInfos);
            }
 
            goalsList.Add(loadedGoal);
        }
        return totalPoints;

    }
    static int RecordEvent(List<Goal> goalsList, int totalPoints)
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < goalsList.Count; i++)
        {
            Console.WriteLine($"    {i+1}. {goalsList[i].GetGoalName()}");
        }
        Console.Write("Which goal did you accomplish?: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;
        int earnedPoint = goalsList[goalIndex].RecordAccomplishment();
        if (earnedPoint < 0)
        {
            Console.WriteLine($"You have lost {earnedPoint * -1} points...");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {earnedPoint} points!");
        }
        totalPoints = totalPoints + earnedPoint;
        if (totalPoints < 0)
        {
            totalPoints = 0;
        }
        Console.WriteLine($"You now have {totalPoints} points.");

        return totalPoints;
    }

}