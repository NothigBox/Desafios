using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJackMultijugador
{
    class Program
    {
        string[] letras = {"A", "J", "Q","K"};
        static void Main(string[] args)
        {
            Console.WriteLine("21 BlackJack");
            Console.Write("¿Empezar a jugar? (s/n): ");

            //Así no tengo que volver los métodos estáticos
            Program pro = new Program();

            string continuar = Console.ReadLine();
            string s = "s", n = "n";

            if (continuar == s) pro.Jugar(continuar);
            else if(continuar == n) Console.WriteLine("Tú te lo pierdes ;)");
            else
            {
                //Hasta que no ponga s o n no funciona >:v
                while (continuar != s && continuar != n)
                {
                    Console.Write("Ingrese 's' para continuar o 'n' para retirarse: ");
                    continuar = Console.ReadLine();
                }
                pro.Jugar(continuar);
            }
        }
        void Jugar(string conf)
        {
            Program pro = new Program();
            string s = "s", n = "n";

            int tieneAs = 0;
            string c1 = "", c2 = "";
            int t = 0;

            if (conf == s)
            {
                Random nL = new Random();
                Random r = new Random();

                //Asigna las cartas
                if (nL.Next(0, 2) == 0) c1 = r.Next(2, 11).ToString();
                else c1 = pro.letras[r.Next(0, 4)];

                if (nL.Next(0, 2) == 0) c2 = r.Next(2, 11).ToString();
                else c2 = pro.letras[r.Next(0, 4)];

                //Suma la carta 1 al total
                if (c1 == "J" || c1 == "Q" || c1 == "K") t += 10;
                else if (c1 == "A")
                {
                    if (t + 11 > 21) t += 1;
                    else t += 11;
                    tieneAs++;
                }
                else t += int.Parse(c1);

                //Suma la carta 2 al total
                if (c2 == "J" || c2 == "Q" || c2 == "K") t += 10;
                else if (c2 == "A")
                {
                    if (t + 11 > 21) t += 1;
                    else 
                    {
                        t += 11;
                        tieneAs++;
                    }
                }
                else t += int.Parse(c2);

                Console.WriteLine("Cartas: {0} , {1}\nTotal: {2}", c1, c2, t);

                while (conf == s)
                {
                    Console.Write("¿Desea continuar? (s/n): ");
                    conf = Console.ReadLine();

                    while (conf != s && conf != n)
                    {
                        Console.Write("Ingrese 's' para continuar o 'n' para retirarse: ");
                        conf = Console.ReadLine();
                    }

                    if (conf == n) break;

                    //Asigna la carta nueva
                    if (nL.Next(0, 2) == 0) c1 = r.Next(2, 11).ToString();
                    else c1 = pro.letras[r.Next(0, 4)];

                    //Suma la carta nueva al total
                    if (c1 == "J" || c1 == "Q" || c1 == "K") t += 10;
                    else if (c1 == "A")
                    {
                        if (t + 11 > 21)
                        {
                            t += 1;
                            Console.WriteLine("A = 1");
                        }
                        else
                        {
                            t += 11;
                            Console.WriteLine("A = 11");
                        }
                        tieneAs++;
                    }
                    else t += int.Parse(c1);

                    Console.WriteLine("Carta: {0}\nTotal: {1}", c1, t);

                    //¿Ganó? ¿Perdió?
                    if (t > 21)
                    {
                        if (tieneAs > 0)
                        {
                            t -= 10;
                            Console.WriteLine("El As cambió de 11 a 1.\nTotal: {0}",t);
                        }

                        //Después de restar un As puede seguir siendo mayor a 21
                        if (t > 21)
                        {
                            Console.WriteLine("Voló.");
                            conf = n;
                            break;
                        }
                    }
                    if (t == 21)
                    {
                        Console.WriteLine("¡Ganó!");
                        break;
                    }
                }
            }
            else Console.WriteLine("Tú te lo pierdes ;)");

            Console.WriteLine("Fin del juego.");
        }
    }
}
