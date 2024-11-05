using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string valueFromUser = Console.ReadLine();

        int grade = int.Parse(valueFromUser);
        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Stretch challenge (1-3)
        int lastDigit = grade % 10;
        string sign;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }
        if (grade >= 97 || letter == "F")
        {
            sign = "";
        }

        // Letter grade printed once
        Console.WriteLine($"Your grade is: {sign}{letter}");

        // check if the student passed

        if (grade >= 70)
        {
            Console.Write("Congrats! You passed the course (:");
        }
        else
        {
            Console.Write("I'm sorry, try again next time ):");
        }

    }
}