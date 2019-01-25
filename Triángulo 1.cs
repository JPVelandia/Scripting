using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Resolvedor de Triángulos1");

            Console.WriteLine("Ingrese z");
            double z = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese y");
            double y = double.Parse(Console.ReadLine());

            double t = Math.Round(Math.Sqrt((y * y) + (z * z)),2);

            double c = Math.Round(Math.Asin(z / t) * (180 / Math.PI),2);

            double a = 180 - 90 - c;

            Console.WriteLine("La hipotenusa mide, {0} \nEl lado c mide {1} \nEl lado a mide {2}", t,c,a);
            



        }
    }
}
