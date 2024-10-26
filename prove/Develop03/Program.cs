using System;

// Showing Creativity and Exceeding Requirements
// This program randomly selects only those words that are not already hidden.
// In addition, it randomly selects a scripture from 3 scriptures.

class Program
{
    static void Main(string[] args)
    {
        
        List<Reference> scriptureList = new();

        string BOOK;
        int CHAPTER;
        int STARTVERSE;
        int ENDVERSE;
        int SINGLEVERSE;
        List<string> VERSETEXTLIST;
        

        // Scripture 1
        BOOK = "Proverbs";
        CHAPTER = 3;
        STARTVERSE = 5;
        ENDVERSE = 6;
        VERSETEXTLIST = ["Trust in the Lord with all thine heart; and lean not unto thine own understanding.","In all thy ways acknowledge him, and he shall direct thy paths."];
        Reference scripture1 = new Reference(BOOK,CHAPTER,STARTVERSE,ENDVERSE,VERSETEXTLIST);

        scriptureList.Add(scripture1);

        // Or just a single verse
        // SINGLEVERSE = 
        // Reference scripture = new Reference(BOOK,CHAPTER,SINGLEVERSE,VERSETEXTLIST);


        // Scripture 2
        BOOK = "John";
        CHAPTER = 3;
        SINGLEVERSE = 16;
        VERSETEXTLIST = ["For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."];
        Reference scripture2 = new Reference(BOOK,CHAPTER,SINGLEVERSE,VERSETEXTLIST);

        scriptureList.Add(scripture2);


        // Scripture 3
        BOOK = "Matthew";
        CHAPTER = 7;
        STARTVERSE = 7;
        ENDVERSE = 8;
        VERSETEXTLIST = ["Ask, and it shall be given you; seek, and ye shall find; knock, and it shall be opened unto you:", "For every one that asketh receiveth; and he that seeketh findeth; and to him that knocketh it shall be opened."];
        Reference scripture3 = new Reference(BOOK,CHAPTER,STARTVERSE,ENDVERSE,VERSETEXTLIST);

        scriptureList.Add(scripture3);


        Random rnd = new Random();
        int rndIndex = rnd.Next(scriptureList.Count);

        scriptureList[rndIndex].Memorizor();


        




    }
}