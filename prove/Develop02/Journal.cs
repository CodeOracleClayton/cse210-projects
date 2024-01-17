using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop02
{
    public class Journal
    {
        public List<Entry> _answers = new List<Entry>();

        public void loadJournal(Entry ourEntry)
        {
            _answers.Add(ourEntry);
        }

        public void DisplayAll(List<Entry> entries)
        {
            foreach (Entry entry in entries)
            {
                Console.WriteLine(entry);
            }
        }

        public void saveFile(string file)
        {
            string fileName = file;
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach (Entry entry in _answers)
                {
                    outputFile.WriteLine("{0}, {1}, {2}", entry._date, entry._promptText, entry._entryText);
                }

            }
        }

        public void LoadFromFile(string file)

        {
            _answers = new List<Entry>();
            string filename = file;
            string[] lines = System.IO.File.ReadAllLines(filename);
            
            foreach  (string line in lines)
            {
                Entry entryFile = new Entry();
                string[] parts  = line.Split(",");
                entryFile._date = parts[0];
                entryFile._promptText = parts[1];
                entryFile._entryText = parts[2];
                
                _answers.Add(entryFile);
            }
        }
    }
}