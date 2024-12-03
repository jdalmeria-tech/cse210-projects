using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Aayah Almeria", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();

        MathAssignment mathAssignment2 = new MathAssignment("Joseph Almeria", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment2.GetSummary());
        Console.WriteLine(mathAssignment2.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment writingAssignment3 = new WritingAssignment("Bill Gates", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment3.GetSummary());
        Console.WriteLine(writingAssignment3.GetWritingInformation());
        Console.WriteLine();
    }
}