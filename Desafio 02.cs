using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02_01
{
    class Program
    {
        //double d;

        static void Main(string[] args)
        {
            Console.WriteLine("Cálculadora de fórmula cuadrática");

            Console.Write("Introduce la a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Introduce la b: ");
            double b = double.Parse(Console.ReadLine()); 

            Console.Write("Introduce la c: ");
            double c = double.Parse(Console.ReadLine());

            double d = (Math.Pow(b, 2)) - (4 * a * c);
            Console.WriteLine("Discriminante: " + d);

            if (d == 0)
            {
                double sol = -b / (2 * a);
                Console.WriteLine("La solución única es: " + sol);
            }

            if(d < 0)
            {
                Console.WriteLine("No es posible calcular la solución.");
            }

            if (d>0)
            {
                double x1 = (-b + (Math.Sqrt(d)) / (2 * a));
                double x2 = (-b - (Math.Sqrt(d)) / (2 * a));

                Console.WriteLine("Las soluciones son: x = {0} y x = {1}", x1, x2);
            }

            /*
            if (Discriminante(a,b,c) == true)
            {
                if (d == 0)
                    UnicaSol(a, b);
                else
                    DosSol(a,b);
            }
            */
        }

        /*
        static bool Discriminante(double a, double b, double c)
        {
            d = (Math.Pow(b, 2)) - (4 * a * c);

            Console.WriteLine(d);

            if (d >= 0)
                return true;
            else
            {
                Console.WriteLine("No es posible calcular la solución.");
                return false;
            }
        }

        static void UnicaSol(double a, double b)
        {
            double sol = -b / (2 * a);
            Console.WriteLine("La solución única es: " + sol);
        }

        static void DosSol(double a, double b)
        {
            double x1 = (-b + (Math.Sqrt(d))/(2*a));
            double x2 = (-b - (Math.Sqrt(d)) / (2 * a));

            Console.WriteLine("Las soluciones son: x = {0} y x = {1}",x1,x2);
        }
        */
    }
}
