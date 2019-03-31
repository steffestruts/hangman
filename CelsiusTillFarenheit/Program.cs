using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusTillFarenheit
{
    class Program
    {
        static double ToFahrenheit(double celsius)
        {
            double fahrenheit = (celsius / 5.0) * 9 + 32;
            return fahrenheit;
        }

        static void Main(string[] args)
        {
            Console.Write("Konvertera Celsius till Fahrenheit: ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Celsius till Fahrenheit är: " + ToFahrenheit(number));

            Console.Read();
        }
    }
}
