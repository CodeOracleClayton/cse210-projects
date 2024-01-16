using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percentage?");
        string percentageMark = Console.ReadLine();
        int actualMark = int.Parse(percentageMark);

        string letter = "";

        if (actualMark >= 90)
        {
            letter = "A";
        }

        else if (actualMark >= 80)
        {
            letter = "B";
        }   

        else if (actualMark >= 70)
        {
            letter = "C";
        }    

        else if (actualMark >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine("Your grade is {0}", letter);

        if (actualMark > 70)
        {
            Console.WriteLine("You have passed!");
        }

        else
        {
            Console.WriteLine("Try to work harder next time");
        }
    }
}