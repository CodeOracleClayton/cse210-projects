using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquareNumber(number);
        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Hello Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name?");
        string Username = Console.ReadLine();

        return Username;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favourite number? ");
        string response = Console.ReadLine();
        int userNumber = int.Parse(response);

        return userNumber;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}