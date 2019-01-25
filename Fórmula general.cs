using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese c");
            double c = double.Parse(Console.ReadLine());

            double d = ((b * b) - (4 * a * c));

            if (d == 0)
            {
                double x = (-b/(2*a));
                Console.WriteLine("La solución es única, la solución es {0}",x);
            }

            if (d > 0)
            {
                double x1 = ((-b + Math.Sqrt(d)) / (2 * a));
                double x2 = ((-b - Math.Sqrt(d)) / (2 * a));
                Console.WriteLine("Las soluciones son \nx1 = {0} \nx2 = {1}", x1,x2);

            }

            if (d < 0)
            {
                Console.WriteLine("No es posible calcular una solución");
            }
        }
    }
}
