using System;

class Program
{
    static void Main(string[] args)
    {

        Journal today = new();

        string newEntry = today.Entry();

        Console.WriteLine(newEntry);

    }
}