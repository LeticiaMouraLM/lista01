using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1exc7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Milhas marítimas: ");
            double milhas = double.Parse(Console.ReadLine());

            double Km = milhas * 1857 / 1000;

            Console.WriteLine("Em quilometros: " + Km);
        }
    }
}
