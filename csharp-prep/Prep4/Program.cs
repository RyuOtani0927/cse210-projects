using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> inputs = new List<int>();

        int inputNum = -1;

        while (inputNum != 0)
        {
            Console.Write("Enter number: ");
            inputNum = int.Parse(Console.ReadLine());

            if (inputNum != 0)
            {
                inputs.Add(inputNum);
            }
            
        }

        int sum = 0;
        int max = -99999999;
        int positiveMin = 999999999;

        foreach (int input in inputs)
        {
            sum = sum + input;

            if (input > max)
            {
                max = input;
            }

            if (input > 0 & input < positiveMin)
            {
                positiveMin = input;
            }
        }

        float average = ((float)sum) / inputs.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {positiveMin}");

        inputs.Sort();

        foreach (int each in inputs)
        {
            Console.WriteLine(each);
        }

    }
}