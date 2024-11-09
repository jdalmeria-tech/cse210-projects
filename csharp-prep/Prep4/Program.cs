using System;
using System.Collections.Generic;

class Program
{
    // Define constants as suggested
    const int LARGEST = -10000000;
    const int SMALLEST = 10000000;
    static void Main(string[] args)
    {
        // Create a list of numbers (0 to stop)
        int number = 1;
        List<int> numberList = new List<int>();

        while (number != 0)
        {
            Console.Write("Enter a number (0 to stop): ");
            number = int.Parse(Console.ReadLine());
            if (number !=0)
            {
                numberList.Add(number);
            }
        }
        // set the variables
        int total = 0;
        int largest = LARGEST;
        int smallestPositive = SMALLEST;

        // find the sum
        foreach (int n in numberList)
        {
            total += n;
            if (n > largest)
            {
                largest = n;
            }
            if (n < smallestPositive && n > 0)
            {
                smallestPositive = n;
            }
        }

        Console.WriteLine($"The sum is: {total}");

        // find the average
        float avg;
        if (numberList.Count == 0)
        {
            avg = 0f;
        }
        else
        {
            avg = (float)total / numberList.Count;
        }
        Console.WriteLine($"The average is: {avg}");

        // give the largest number
        if (largest == LARGEST)
        {
            Console.WriteLine("No largest number found!");
        }
        else
        {
            Console.WriteLine($"The largest number is: {largest}");
        }

        // give the smallest positive number
        if (smallestPositive == SMALLEST)
        {
            Console.WriteLine("No positive numbers!");
        }
        else
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        // sort the list and print it
        numberList.Sort();
        Console.WriteLine($"The sorted list is:");
        foreach (int num in numberList)
        {
            Console.WriteLine(num);
        }
    }
}