using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terning2Opgave
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t1 = new Terning();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();

            Terning t2 = new Terning(5);
            t2.Skriv();
            t2.Ryst();
            t2.Skriv();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . .");
                Console.ReadKey();
            }
        }
    }

    public class Terning
    {
        public Terning()
        {
            Ryst();
        }

        public Terning(int værdi)
        {
            if (værdi < 1 || værdi > 6)
                this.værdi = 1;
            else
                this.værdi = værdi;
        }

        private static Random rnd = new Random();

        private int værdi;

        public int Værdi
        {
            get
            {
                return værdi;
            }
            set
            {
                if (value < 1 || value > 6)
                    værdi = 1;
                else
                   værdi = value;
            }
        }  
        
        public void Ryst()
        {
            this.værdi = rnd.Next(1, 7);
        }

        public void Skriv()
        {
            Console.WriteLine("[" + this.værdi + "]");
        }
    }
}
