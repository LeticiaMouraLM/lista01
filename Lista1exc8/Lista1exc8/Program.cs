using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1exc8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Temperatura em Celsius: ");
            double c = double.Parse(Console.ReadLine());

            double d = (c * 9 / 5) + 32;

            Console.WriteLine("Fahrenheit: " + d);

        }
    }
}
