using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine();
        
        Console.Write("What is your grade percentage: ");
        string input = Console.ReadLine();
        float percentage = int.Parse(input);
        string grade = "";

        if (percentage >= 90)
        {
            grade = "A";
        }
        else if (percentage >= 80)
        {
            grade = "B";
        }
        else if (percentage >= 70)
        {
            grade = "C";
        }
        else if (percentage >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        float remainder = 0;

        if (percentage <= 93 && percentage >= 60)
        {
            remainder = percentage % 10;

            if (remainder >= 7)
            {
                grade = grade + "+";
            }
            else if (remainder < 3)
            {
                grade = grade + "-";
            }
        }

        Console.WriteLine($"Your grade is {grade}.");

        Console.WriteLine();

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("You failed the course. Good luck with your next time.");
        }

        Console.WriteLine();


    }
}