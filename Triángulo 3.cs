using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = 3;
            double c = 56.31;
            double c1 = c * (Math.PI / 180);

            double t = z / Math.Sin(c1);
            //*double t1 = t * (180 / Math.PI);/*

            double y = Math.Sqrt((t * t) - (z * z));

            double a = 180 - c - 90;


            Console.WriteLine("La hipotenusa mide {0}",t);

            Console.WriteLine("El cateto y mide {0}",y);

            Console.WriteLine("El ánulo a mide {0}",a);

        }
    }
}
