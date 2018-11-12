using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgenExceptOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            string filName = "c:\\temp\\tal.txt";
            if (!System.IO.File.Exists(filName))
            {
                ApplicationException e = new ApplicationException("Filen " + filName + " findes ikke");
                Console.WriteLine(e.Message);
            }



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . .");
                Console.ReadKey();
            }
        }
    }
}
