using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut01_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
      




            try
            {
                Console.Title = "Calculator";
                start:
                int cislo1 = 0;
                int cislo2 = 0;
                int vysledek = 0;
                Console.Write("Zadejte první číslo:");
                cislo1 = int.Parse(Console.ReadLine());
                Console.Write("Zadejte druhé číslo:");
                cislo2 = int.Parse(Console.ReadLine());
                Console.Write("Zadej znaménko:");
                char znamenko =char.Parse( Console.ReadLine());
                if (znamenko == '+')
                {
                    vysledek = cislo1 + cislo2;
                }
                else if (znamenko == '-')
                {
                    vysledek = cislo1 - cislo2;
                }

                else if (znamenko == '*')
                {
                    vysledek = cislo1 * cislo2;
                }
                else if (znamenko == '/')
                {
                    vysledek = cislo1 / cislo2;
                }
                else { Console.WriteLine("Neplatné znaménko, použiji tedy plus");
                    vysledek = cislo1 + cislo2;
                }
                

                Console.WriteLine("Vysledek je: " + vysledek);
                //ukonci se az uzivatel zmackne jakoukoliv klavesu
                Console.ReadKey();
                Console.Clear();
                goto start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                System.Environment.Exit(-1);
            }

        }
    }
}
