using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new System.Text.StringBuilder("Hello World");

            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('-', 10));
            
            Console.WriteLine(builder);

            Console.WriteLine("First Char: " + builder[0]);
        }
    }
}
