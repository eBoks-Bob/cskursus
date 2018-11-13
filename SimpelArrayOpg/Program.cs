using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpelArrayOpg
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] månedsløn = { 10000, 20000, 15000, 20000, 30000, 15000 };

            double sum = 0;

            for (int i = 0; i < månedsløn.Length; i++)
            {
                sum = sum + månedsløn[i];
                Console.WriteLine(månedsløn[i]);
            }

            double gns = sum / månedsløn.Length;
            Console.WriteLine("Gennemsnit " + gns.ToString());

            int[] kopi = månedsløn.Clone() as int[];

            System.Array.Sort(kopi);

            foreach (var item in kopi)
            {
                Console.WriteLine(item);    
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . .");
                Console.ReadKey();
            }
        }
    }
}
