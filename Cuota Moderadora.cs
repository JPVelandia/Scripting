using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 828116;

            Console.WriteLine("Conozca su subsidio");
            Console.WriteLine("Ingrese su salario mensual");

            double y = double.Parse(Console.ReadLine());

            if (y < 2 * x)
            {
                Console.WriteLine("Le corresponde la Tarifa A");
                Console.WriteLine("Su cuota moderadora es de 3200");

            }

            if (y >= x * 2 && y < x * 5)
            {
                Console.WriteLine("Le corresponde la Tarifa B");
                Console.WriteLine("Su cuota moderadora es de 12700");
            }

            if (y >= 4 * x)
            {
                Console.WriteLine("Le corresponde la Tarifa C");
                Console.WriteLine("Su cuota moderadora es de 33500");
            }



        }
    }
}
