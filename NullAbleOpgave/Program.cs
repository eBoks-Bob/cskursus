using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullAbleOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            bool? res; 
            res = HentFraDb(1);
            Console.WriteLine($"resultat = {res}");

            res = HentFraDb(2);
            Console.WriteLine($"resultat = {res}");

            res = HentFraDb(5);
            Console.WriteLine($"resultat = {res}");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . .");
                Console.ReadKey();
            }
        }

        static bool? HentFraDb(int tal)
        {
            switch (tal)
            {
                case 1:
                    return (true);
                case 2:
                    return (false);
                default:
                    return (null);
            }
        }
    }
}
