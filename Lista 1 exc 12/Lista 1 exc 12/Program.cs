using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_exc_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
         double soma= 0;

         for (int i = 1; i <= 5; i++)
                
         Console.Write("Valor do produto " + i + ": ");
         soma += double.Parse(Console.ReadLine());

         Console.Write("Valor pago: ");
         double pago = double.Parse(Console.ReadLine());    

         double troco = pago - soma;

         Console.WriteLine("Troco: R$" + troco);



        }
    }
}
