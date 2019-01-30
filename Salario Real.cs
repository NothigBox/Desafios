using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Resolvedor de salario");
            Console.Write("Ingrese salario: ");

            double a = double.Parse(Console.ReadLine());

            Console.Write("Ingrese tipo de contrato (1 para dependiente o 2 para independiente): ");

            int b = int.Parse(Console.ReadLine());
            int c = 0;

            if (b == 2)
            {
                Console.Write("Ingrese tipo de riesgo de 1 a 5: ");

                c = int.Parse(Console.ReadLine());
            }

            double smm = 828116;
            double bdc = a * 0.4;
            double t = 0;

            if (bdc < smm)
            {
                bdc = smm;
            }

            double pension = 0;
            double EPS = 0;
            double ARL = 0;

            if (b == 1)
            {
                pension = bdc * 0.04;
                EPS = bdc * 0.04;

                t = a * 13;

            }

            if (b == 2)
            {
                pension = bdc * 0.16;
                EPS = bdc * 0.125;
                switch (c)
                {
                    case 1: ARL = bdc * 0.00522;
                        break;
                    case 2:
                        ARL = bdc * 0.01044;
                        break;
                    case 3: ARL = bdc * 0.02436;
                        break;
                    case 4: ARL = bdc * 0.04350;
                        break;
                    case 5: ARL = bdc * 0.06960;
                        break;


                }

                t = a * 12;
            }

            double deducciont = pension + EPS + ARL;

            Console.WriteLine("Sus deducciones totales son: ");
            Console.WriteLine(-deducciont);

            Console.WriteLine("Su salario real mensual es: ");
            double r = a - deducciont;
            Console.WriteLine(r);

            Console.WriteLine("Su salario anual con prima sin deducciones es :");
            Console.WriteLine(t);

        }
    }
}