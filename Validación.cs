using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eres un robot?");
            Console.WriteLine("Resolver 9 + 4");
            int respuesta = int.Parse(Console.ReadLine());
            int contador = 0;

            while (respuesta != 13)
            {
                
                contador++;

                Console.WriteLine("Intente otra vez");
                Console.WriteLine("Resolver 9 + 4");
                respuesta = int.Parse(Console.ReadLine());


                if (contador == 2)
                {
                    Console.WriteLine("Ya no tiene más intentos");
                    break;

                }
            }

            Console.WriteLine("Eres humano");


        }
    }
}
