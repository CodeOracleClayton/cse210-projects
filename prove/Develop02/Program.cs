using System;
using Develop02;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Entry entry = new Entry();
        PromptGenerator promptList = new PromptGenerator();

        DateTime dateTime = new DateTime();
        string dateText =  dateTime.ToShortDateString();

        Console.WriteLine("Welcome to the Journal Program!");

        int answer = -1;

        while (answer != 5)
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
            Console.Write("What would you like to do?");
            string userAnswer = Console.ReadLine();
            answer = int.Parse(userAnswer);

            if (answer == 1)
            {
                string mySuggestion = promptList.getPrompt();
                Console.WriteLine(mySuggestion);
                string todayEntry = Console.ReadLine();
                entry._date = DateTime.Today.ToString();
                entry._promptText = mySuggestion;
                entry._entryText = todayEntry;
                journal.loadJournal(entry);
                
            }

            else if (answer == 2)
            {
                foreach (Entry journalEntry in journal._answers)
                {
                    journalEntry.display();
                }
            }

            else if (answer == 3)
            {
                Console.Write("What is the filename?");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }

            else if (answer == 4)
            {
                Console.Write("What is the filename?");
                string filename = Console.ReadLine();
                journal.saveFile(filename);
            }

            else
            {
                Console.WriteLine("Quit");
            }
        }
    }
}