using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_exc10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("cotação do dolar:");
            double cotação = double.Parse(Console.ReadLine());

            Console.Write("Quantidade em dólares: ");
            double dolares = double.Parse(Console.ReadLine());

            double reais = cotação * dolares;

            Console.WriteLine("Valor em reais: R$ " + reais);
        }
    }
}
