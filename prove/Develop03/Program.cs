using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the scripture memorizer!");

        Scripture myScripture = new Scripture("Proverbs", "3", "5-6", "Trust in the LORD with all your heart and lean not on your own understanding;  in all your ways acknowledge him, and he will make your paths straight.");
        bool finish = false;
        string answer;
        while (finish == false)
        {
            Console.WriteLine("Press the Enter key to continue or type quit to finish");
            answer = Console.ReadLine();
            myScripture.DisplayRenderedText();
            myScripture.HideWords();
            myScripture.IsCompletelyHidden();
            if (answer == "quit")
            {
                finish = true;
            }


        }
    }
}