using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lista1exc6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Valor 1: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Valor 2: ");
            double b = double.Parse(Console.ReadLine());

            double media = Math.Sqrt( a * b );

            Console.WriteLine("Media geométrica: " + media);
        }
    }
}
