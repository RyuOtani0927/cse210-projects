using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Hello Develop03 World!");
        Console.WriteLine();

        string BOOK = "Proverbs";
        int CHAPTER = 3;
        int STARTVERSE = 5;
        int ENDVERSE = 6;
        List<string> VERSELIST = ["Trust in the Lord with all thine heart; and lean not unto thine own understanding.","In all thy ways acknowledge him, and he shall direct thy paths."];
        
        Reference scripture = new Reference(BOOK,CHAPTER,STARTVERSE,ENDVERSE,VERSELIST);

        // Or just a single verse
        // int SINGLEVERSE = 
        // Reference scripture = new Reference(BOOK,CHAPTER,SINGLEVERSE,VERSELIST);

        scripture.DisplayEachVerse();

        




    }
}