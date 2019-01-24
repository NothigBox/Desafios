using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalePuesOme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario en $COP: ");
            double salario = double.Parse(Console.ReadLine());

            double smlv = 828116;

            if (salario < (smlv * 2))
            {
                Console.WriteLine("Su tarifa a pagar es la A");
            }

            if (salario >= (smlv * 2) && salario < (smlv * 4))
            {
                Console.WriteLine("Su tarifa a pagar es la B");
            }

            if (salario >= (smlv * 4))
            {
                Console.WriteLine("Su tarifa a pagar es la C");
            }
        }
    }
}
