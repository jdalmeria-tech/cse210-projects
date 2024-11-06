using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string userName = PromptUserName();
        int faveNum = PromptUserNumber();
        int squaredNum = SquareNumber(faveNum);
        DisplayResult(userName,squaredNum);
    }
    // first function: print welcome message
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // second function: ask user's name
    static string PromptUserName()
    {
        Console.Write("Please eneter your name: ");
        string name = Console.ReadLine();

        // name capitalization
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        return textInfo.ToTitleCase(name.ToLower());
    }

    // third function: ask user's favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // fourth function: square the fave number from the user
    static int SquareNumber(int number)
    {
        int squareNum = (int)Math.Pow(number, 2);
        return squareNum;
    }

    // fifth function: display the results (name and squared number)
    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}