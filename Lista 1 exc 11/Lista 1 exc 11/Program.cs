using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lista_1_exc_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("digite X: ");
            double X = double.Parse(Console.ReadLine());

            Console.Write("Digite y: ");
            double y = double.Parse(Console.ReadLine());

            double resultado = Math.Pow (X, y);

            Console.WriteLine("resultado: " + resultado);

        }
    }
}
