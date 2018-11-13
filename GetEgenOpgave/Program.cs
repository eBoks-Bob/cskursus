using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEgenOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            Trekant t1 = new Trekant(20, 10);
            Console.WriteLine(t1.Areal);

            Trekant t2 = new Trekant(100, 40);
            Console.WriteLine(t2.Areal);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press and key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    class Trekant
    {
        public int Grundlinie { get; private set; }
        public int Højde { get; private set; }

        public Trekant (int grundlinie, int højde)
        {
            Grundlinie = grundlinie;
            Højde = højde;
        }

        public double Areal
        {
            get
            {
                return Grundlinie * Højde * 0.5;
            }
        }
    }
}
