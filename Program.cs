using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the student's score (0-100):");

        // Read the score and convert it to a number
        int score = Convert.ToInt32(Console.ReadLine());

        // Use an if-else statement to check if the score is a passing grade (50 or higher)
        if (score >= 50)
        {
            Console.WriteLine("Result: Pass");
        }
        else
        {
            Console.WriteLine("Result: Fail");
        }
    }
}