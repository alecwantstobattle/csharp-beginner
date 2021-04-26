using Classes.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introducte();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            System.Console.WriteLine(result);
        }
    }
}
