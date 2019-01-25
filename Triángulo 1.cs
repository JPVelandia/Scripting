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

            Console.WriteLine("Ingrese t");
            double t = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese a");
            double a = double.Parse(Console.ReadLine());

            double y = t * Math.Sin(a);
            double z = t * Math.Cos(a);


            

            double c = 180 - 90 - a;

            Console.WriteLine("El lado y mide {0} \nEl lado z mide {2} \nEl ángulo c mide {2}", y,z,c);
            



        }
    }
}
