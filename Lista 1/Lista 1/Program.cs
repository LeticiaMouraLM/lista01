using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a diagonal: ");
            double d = double.Parse(Console.ReadLine());

            double area = (d * d) / 2;

            Console.WriteLine("area do quadrado:" + area);

        }
    }
}
