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

            if (y < 2*x)
            {
                Console.WriteLine("Le corresponde la Tarifa A");
            }

            if (y >=x*2 && y < x*4)
            {
                Console.WriteLine("Le corresponde la Tarifa B");
            }

            if (y >= 4*x)
            {
                Console.WriteLine("Le corresponde la Tarifa C");
            }



        }
    }
}
