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
            Console.WriteLine("Contador de votos");
            Console.Write("Votos por el partido A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Votos por el partido B: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Votos en blanco: ");
            int blanco = int.Parse(Console.ReadLine());

            Console.Write("Votos anulados: ");
            int anulado = int.Parse(Console.ReadLine());

            Console.Write("Población total: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("% población mayor de edad: ");
            double p = double.Parse(Console.ReadLine());

            int mayoresDeEdad = (int)(n * (p / 100));
            int abstencion = mayoresDeEdad - (a + b);

            bool menosAnulados = anulado < (a + b) * 0.3;
            bool menosVotoBlanco = (a + b) > blanco;
            bool abstenidos = mayoresDeEdad - (a + b + blanco + anulado) < (a + b + blanco + anulado);

            Console.WriteLine("Mayores de edad: " + mayoresDeEdad);
            Console.WriteLine("Total votantes: " + (a + b + blanco + anulado));
            Console.WriteLine("Abstención: " + (mayoresDeEdad - (a + b + blanco + anulado)));

            if ((menosAnulados || menosVotoBlanco) && abstenidos)
            {

                Console.WriteLine("Votaciones exitosas");

                if (a < b)
                    Console.WriteLine("Ganó B");
                else if (b < a)
                    Console.WriteLine("Ganó A");
                else if (b == a)
                    Console.WriteLine("Empate");



            }
            else Console.WriteLine("Repetir votaciones");
        }
    }
}
