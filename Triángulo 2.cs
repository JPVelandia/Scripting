using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Resolvedor de Triángulos1");

            double u = (Math.PI / 180);
            double w = (180 / Math.PI);

            Console.WriteLine("Ingrese t");
            double t = 3.61;

            Console.WriteLine("Ingrese a");
            double a = 33.69;
        
            double y = (t * Math.Sin(a))  ;
            double y1 = (int)y;
            double z = Math.Sqrt((t * t) - (y1 * y1)) ;

            double z1 = (int)z;
            





            double c = 180 - 90 - a;

            Console.WriteLine("El lado y mide {0} \nEl lado z mide {1} \nEl ángulo c mide {2}", y1, z1, c);

        }
    }
}
