using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        // Ask a user for their name
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        // Add a break line
        Console.WriteLine();
        Console.WriteLine($"Your name is {last}, {first} {last}.");

    }
}