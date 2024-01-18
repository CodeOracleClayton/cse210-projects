using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JournalApp
{
    public class Journal
    {
        public List<Entry> _entries = new List<Entry>();

        public void AddEntry(Entry newEntry)
        {
            _entries.Add(newEntry);
        }

        public void DisplayAll()
        {
            foreach (Entry entry in _entries)
            {
                Console.WriteLine(entry);
            }
        }

        public void SaveToFile(string _filename)
        {
            string filename = _filename;

            using (StreamWriter sw = new StreamWriter(filename))
            {
                foreach(Entry entry in _entries)
                {
                    sw.WriteLine("{0}, {1}, {2}", entry._date, entry._prompText, entry._entryText);
                }
            }

        }

        public void LoadFromFile(string filename)
        {
            _entries = new List<Entry>();
            string _filename = filename;
            string[] lines = System.IO.File.ReadAllLines(_filename);
            foreach (string line in lines)
            {
                Entry entryFile = new Entry();
                string[] parts = line.Split(",");
                entryFile._date = parts[0];
                entryFile._prompText = parts[1];
                entryFile._entryText = parts[2];

                _entries.Add(entryFile);
            }

        }

    }
}
