using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySplitOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "3;5;22;1;10;15;5";
    
            string[] atxt = txt.Split(';');
            int sum = 0;

            for (int i = 0; i < atxt.Length; i++)
            {
               sum = sum + Convert.ToInt32(atxt[i]);
            }

            Console.WriteLine($"summen er {sum:N2}");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . .");
                Console.ReadKey();
            }
        }
    }
}
