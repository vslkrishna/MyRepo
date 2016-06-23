using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new CalculatorLib.Calculator();
            var result = calc.Sum(3, 4);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
