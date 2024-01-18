using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalApp
{
    public class Entry
    {
        public string _date;
        public string _prompText;
        public string _entryText;

        public void Display()
        {
            Console.WriteLine("{0}, - {1}", _date, _prompText);
            Console.WriteLine("{0}", _entryText);
            Console.WriteLine("");
        }
    }
}
