using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        List<int> numberList;
        numberList = new();

        int input = -9999999;

        while (input != 0)
        {

            Console.Write("Enter a number: ");
            string inputString = Console.ReadLine();
            input = int.Parse(inputString);
            numberList.Add(input);
        }

        foreach (int item in numberList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(numberList);

    }
}