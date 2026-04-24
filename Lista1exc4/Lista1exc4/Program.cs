using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1exc4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Base: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Altura: ");
            double h = double.Parse(Console.ReadLine());

            double area = (b * h) / 2;

            Console.WriteLine("Area do triangulo: " + area);

        }
    }
}
