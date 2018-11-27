using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegateOpg
{
    //public delegate void MinDelegate1(string txt);

    class Program
    {
        static void Main(string[] args)
        {
            //MinDelegate1 f1 = new MinDelegate1(MinSkrivTilConsole);
            //f1.Invoke("Test");

            Action<string> f2 = MinSkrivTilConsole;
            f2("Test");

            Action<string> f3 = MinSkrivTilConsole;
            f3 += Console.WriteLine;
            f3("Test");

            //f1 -= MinSkrivTilConsole;
            f2 -= MinSkrivTilConsole;
            f3 -= MinSkrivTilConsole;
            f3 -= Console.WriteLine;
           
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press and key to continue . . . ");
                Console.ReadKey();
            }
        }

        static void MinSkrivTilConsole(string txt)
        {
            Console.WriteLine("**** " + txt + " ****");
        }
    }
}
