using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int a = 0, b = 0;
            string conf = "";

            //Re-start
            Start:

            Console.Write("¿Jugar? (s/n): ");
            conf = Console.ReadLine();

            int t = 0, mayor = 0, tiros = 0,par=0;

            //Solo se puede s o n
            Val:
            while (conf != "s" && conf != "n")
            {
                Console.Write("'s' para continuar 'n' para terminar: ");
                conf = Console.ReadLine();
            }

            while(t<100 && conf == "s")
            {
                a = r.Next(1, 11);
                b = r.Next(1, 11);

                t += a + b;
                tiros++;

                Console.WriteLine("Dados: {0} y {1}\nSuma: {2}\n\tTotal: {3}",a,b,a+b,t);
                if (a==1&&b==1)
                {
                    t = 1000;
                    Console.WriteLine("\n\t*Sacaste dos 1, RIP.*\n");
                    break;
                }
                    
                if (a + b > 6) mayor++;
                if (a == b)
                {
                    par++;
                    if (par >= 3)
                    {
                        t = 100;
                        Console.WriteLine("\n\t*Sacaste 3 pares seguidos, vaya suerte.*\n");
                        break;
                    }
                }
                else par = 0;

                if (t>100||t==100)break;

                Console.Write("¿Desea continuar? (s/n): ");
                conf = Console.ReadLine();

                goto Val;
            }
            if (conf != "n")
            {
                if (t == 100) Console.WriteLine("¡Ganaste!");
                else Console.WriteLine("Mejor suerte la póxima.");

                Console.WriteLine("% de tiros mayores a 6: {0}\n", ((decimal)mayor / tiros) * 100);

                goto Start;
            }
            if(tiros > 0) Console.WriteLine("% de tiros mayores a 6: {0}", ((decimal)mayor / tiros) * 100);

            if (conf == "n") Console.WriteLine("Bye.");
        }
    }
}
