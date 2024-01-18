using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace JournalApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PromptGenerator promptGenerator = new PromptGenerator();
            Journal journal = new Journal();

            DateTime dateTime = DateTime.Now;  
            string dateTimeNow = dateTime.ToShortDateString();

            Console.WriteLine("Welcome to the Journal Program!");

            int answer = -1;

            while (answer != 5 )
            {
                Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
                Console.Write("What would you like to do? ");
                string myAnswer = Console.ReadLine();
                answer = int.Parse(myAnswer);

                switch (answer)
                {
                    case 1:
                        Entry entry = new Entry();
                        string myPromptText = promptGenerator.GetRandomPrompt();
                        Console.WriteLine(myPromptText);
                        Console.Write(">");
                        string myText = Console.ReadLine();
                        entry._prompText = myPromptText;
                        entry._date = dateTimeNow;
                        entry._entryText = myText;
                        journal.AddEntry(entry);
                        break;

                    case 2:
                        foreach (Entry journalEntries in journal._entries)
                        {
                            journalEntries.Display();
                        }
                        break;

                    case 3:
                        Console.Write("What is the file name?");
                        string _filename = Console.ReadLine();
                        journal.LoadFromFile(_filename);
                        break;

                    case 4:
                        Console.Write("What is file name?");
                        string filename = Console.ReadLine();
                        journal.SaveToFile(filename);
                        break;

                    case 5:
                        Console.WriteLine("Quit");
                        break;
                }
            }
        }

    }
}
