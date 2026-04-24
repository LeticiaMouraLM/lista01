using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lista1ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Diãmetro: ");
            double d = double.Parse(Console.ReadLine());

            double r = d / 2;
            double area = Math.PI * r * r;

            Console.WriteLine ("Área do circulo: " + area);


        }
    }
}
