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
    }
}