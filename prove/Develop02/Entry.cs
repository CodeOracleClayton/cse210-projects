using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop02
{
    public class Entry
    {
        public string _date;
        public string _promptText;
        public string _entryText;

        public void Display()
        {
            Console.WriteLine("Date: {0} - Prompt: {1}", _date, _promptText);
            Console.WriteLine(_entryText);
        }
    }
}