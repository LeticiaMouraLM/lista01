using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            int h;
            int a;

            Console.WriteLine("informe a Base do retangulo");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("informe a altura do retangulo");
            h = int.Parse(Console.ReadLine());

            a = b * h; 

            Console.WriteLine("A area do retangulo é");
            Console.WriteLine(a);
        }
    }
}         

        