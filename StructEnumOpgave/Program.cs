using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructEnumOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            Filtyper ft = Filtyper.csv;

            Console.WriteLine(ft);
            Console.WriteLine(Convert.ToInt32(ft));

            Person p = new Person();
            p.id = 1;
            p.navn = "Mikkel";
            p.fødselsdato = new DateTime(1939, 10, 21);

            Console.WriteLine(p.navn);
            Console.WriteLine(p.fødselsdato);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press and key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
