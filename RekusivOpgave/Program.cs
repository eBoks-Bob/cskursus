using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekusivOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            LøkkeSomeMetode(1, 10);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . .");
                Console.ReadKey();
            }
        }

        static void LøkkeSomeMetode(int start, int slut)
        {
            Console.WriteLine(start);

            if (start == slut)
                return;

            start++;
            LøkkeSomeMetode(start, slut);
        }
    }
}
