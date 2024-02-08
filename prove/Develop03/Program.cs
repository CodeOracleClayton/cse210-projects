using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        string userInput = "";

        Console.WriteLine("-----------Welcome to the Scripture Memorizer App----------------");
        Console.WriteLine(" ");
        Console.WriteLine("Choose level: \n1. Level 1 \n2. Level 2\n3. Level 3");
        string answer = Console.ReadLine();
        int HideNumber = int.Parse(answer);

        while (userInput.ToLower() != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine(" ");

            Console.WriteLine("Press Enter to continue or type 'quit' to finish");
            userInput = Console.ReadLine();

            if (scripture.IsCompletelyHidden())
                break;

            for (int i = 0; i < 3; i++)
            {
                scripture.HideRandomWords(HideNumber);
                if (scripture.IsCompletelyHidden())
                    break;
            }
        }
    }
}
