using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummarizingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really long text";
            var summary = StringUtility.SummarizeText(sentence);
            Console.WriteLine(summary);            
        }
    }
}
