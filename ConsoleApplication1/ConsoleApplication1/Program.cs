using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// Calculator Class
    /// </summary>
    class Program
    {
        /// <summary>
        /// Calculator Methods
        /// </summary>
        /// <param name="a">input parameter</param>
        /// <param name="b">input parameter</param>
        /// <param name="c">result parameter</param>
        static void Main(string[] args)
        {
            var calc = new CalculatorLib.Calculator();

            var result = calc.Sum(3, 4);
            Console.WriteLine(result);

            result = calc.Muliply(3, 4);
            Console.WriteLine(result);

            result = calc.Divide(3, 4);
            Console.WriteLine(result);

            result = calc.Divide(7, 4);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
