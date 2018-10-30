using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int tal = 0; tal <=19; tal++)
            {
                if (tal % 3 != 0)
                    continue;
                
                if (tal > 15)
                    break;

                Console.WriteLine(tal);                 
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press and key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
