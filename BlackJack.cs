using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();




            int carta1 = random.Next(1, 12);
            int carta2 = random.Next(1, 12);
            int total = carta1 + carta2;

            Console.WriteLine("Sus cartas son: {0},{1} " ,carta1,carta2);
            Console.WriteLine("En total lleva: {0} ", total);

            while (total <= 21)
            {
                Console.WriteLine("Desea seguir jugando? s/n ");
                string respuesta = Console.ReadLine();
                if (respuesta == "s")
                {
                    carta1 = random.Next(1, 12);
                    total += carta1;
                    Console.WriteLine("Lleva {0} puntos", total);

                    if (total > 21)
                    {
                        Console.WriteLine("Ha perdido");
                    }
                }
                else { Console.WriteLine("Su puntaje final fue {0} ", total);
                    break;
                }
            }


        }
    }
}
