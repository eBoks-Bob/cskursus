using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekusivOpgaveX
{
    class Program
    {
        static void Main(string[] args)
        {
            LøkkeSomeMetode(1, 25);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . .");
                Console.ReadKey();
            }
        }

        static void LøkkeSomeMetode(int start, int slut)
        {
            if (start == slut)
                return;

            Console.WriteLine("tal = " + start);
            start++;
            LøkkeSomeMetode(start, slut);
        }     
    }
}
