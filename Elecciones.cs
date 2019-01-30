using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Resolvedor de elecciones");
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

            Console.Write("% de la población mayor de edad: ");
            double p = double.Parse(Console.ReadLine());

            bool cloneMachine = a + b + blanco + anulado > n;
            bool cuasiEmpate = Math.Abs(a - b) < a + b + blanco + anulado;

            bool votantes = a + b + blanco + anulado < n * 0.3;


            if ((cloneMachine || cuasiEmpate) && votantes)
                Console.WriteLine("Las eleciones deben ser ejecutadas nuevamenta");
            else
            {
                if (a > b)
                    Console.WriteLine("El ganador es A");
                else
                    Console.WriteLine("El ganador es B");
            }

        }
    }
}