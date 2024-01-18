using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalApp
{
    public class PromptGenerator
    {
        List<string> _prompts = new List<string>
        {
            "How was your day?",
            "Did you meet anyone today?",
            "In what way was this day different from other days?",
            "How did you feel throughout the day today? Did it change?",
            "What am I grateful for today?",
            "What did I accomplish today?"
        };

        public string GetRandomPrompt()
        {
            Random random = new Random();
            int number = random.Next(0, _prompts.Count - 1);
            return _prompts[number];
        }
    }
}
