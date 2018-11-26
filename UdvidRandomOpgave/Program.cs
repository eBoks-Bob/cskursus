using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdvidRandomOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            UdvidetRandom r = new UdvidetRandom();
            Console.WriteLine(r.Nextbool());

            if (System.Diagnostics.Debugger.IsAttached)

            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    class UdvidetRandom : System.Random
    {
        public bool Nextbool()
        {
           return (this.Next(1, 1002) <= 500);
        } 
    }
}
