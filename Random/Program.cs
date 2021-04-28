using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new System.Random();
            //for (var i = 0; i < 10; i++)
            //    //Console.WriteLine(random.Next());
            //    Console.WriteLine(random.Next(1, 10));

            //Console.WriteLine((int)'a');

            //for (var i = 0; i < 10; i++)
            //    //Console.Write((char)random.Next(97, 122));
            //    Console.Write((char)('a' + random.Next(0, 26)));
            //Console.WriteLine();

            const int passwordLength = 10;

            var buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));

            var password = new string(buffer);

            Console.WriteLine(password);
        }
    }
}
