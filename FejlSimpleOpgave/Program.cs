using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FejlSimpleOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Der er sket en fejl",ex.Message);
                Prøvigen();
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . .");
                Console.ReadKey();
            }
        }

        static void Run()
        {
            Console.WriteLine("Indtast 1. tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            
            
            Console.WriteLine("Indtast 2. tal");
            int tal2 = Convert.ToInt32(Console.ReadLine());

            int res = tal1 + tal2;
            Console.WriteLine("resultat er " + res);           
        }

        static void Prøvigen()
        {
            int prøveAntalGang = 3;
            int antal = 0;

            while (antal < prøveAntalGang)
            {
                try
                {
                    Run();
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Der er en fejl " + ex.Message);
                    antal++;
                }
            }
        }
    }
}
