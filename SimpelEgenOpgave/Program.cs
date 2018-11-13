using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpelEgenOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare v1 = new Vare();
            v1.Navn = "Sko";
            v1.Pris = 450;
            Console.WriteLine(v1.Navn);
            Console.WriteLine(v1.Pris);
            Console.WriteLine(v1.PrisMedMoms());

            Vare v2 = new Vare("Frakke", 2500);
            Console.WriteLine(v2.PrisMedMoms());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . .");
                Console.ReadKey();
            }
        }
    }
    
    class Vare
    {
        
        public Vare() { } 

        public Vare (string navn, double pris)
        {
            this.navn = navn;
            this.pris = pris;
        }

        private string navn;

        public string Navn
        {
            get
            {
                Console.WriteLine("Nu aflæses navn");
                return navn;
            }
            set
            {
                Console.WriteLine("Nu tildeles navn");
                navn = value;
            }
        }

        private double pris;

        public double Pris
        {
            get
            {
                Console.WriteLine("Nu aflæses pris");
                return pris;
            }
            set
            {
                Console.WriteLine("Nu tildeles pris");
                pris = value;
            }
        }

        public double PrisMedMoms()
        {
            return this.pris * 1.25;
        }
        
    }     
}
