
// CSE210 W04 Prove: Developer
// Ryu Otani

// Exceeding Requirements
// 1. It keeps asking what the user would like to do, if the response is not between 1-5.
// 2. Added one more information "score" in addition to date, prompt, and response.


using System;

class Program
{
    static void Main(string[] args)
    {

        Journal newJournal = new();

        newJournal.Menu();

    }
}