using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
       

         Console.Write("Digite o valor da aresta: ");
         Double Aresta = Double.Parse(Console.ReadLine());

         Double Area = Aresta * Aresta;

         Console.WriteLine("Area do quadrado: " + Area);



        }
    }
}
