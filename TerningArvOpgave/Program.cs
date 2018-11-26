using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerningArvOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t1 = new Terning();
            t1.Skriv();

            t1.Ryst();
            t1.Skriv();
            Terning t2 = new Terning(4);
            t2.Skriv();
            t2.Ryst();
            t2.Skriv();

            LudoTerning l1 = new LudoTerning();
            l1.Skriv();
            
            LudoTerning l2 = new LudoTerning(5);
            l2.Skriv();
            
            l2.Ryst();
            l2.Skriv();      

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . .");
                Console.ReadKey();
            }
        }

        public class Terning
        {
            private static System.Random rnd;
            private int værdi;

            public int Værdi
            {
                get { return this.værdi; }
                set
                {
                    if (value < 1 || value > 6)
                        value = 1;
                    this.værdi = value;
                }
            }

            public virtual void Skriv()
            {
                Console.WriteLine("["+this.Værdi+"]");
            } 

            public void Ryst()
            {
                this.Værdi = rnd.Next(1, 7);
            }    

            public Terning(int værdi)
            {
                this.værdi = værdi;
            } 

            public Terning()
            {
                rnd = new Random();
            }
        }

        public class LudoTerning : Terning
        {
            public LudoTerning() : base ()
            {
            }

            public LudoTerning(int værdi) : base (værdi)
            {
            }

            public bool ErGlobus()
            {
                return this.Værdi == 3;
            } 

            public bool ErStjerne()
            {
                return this.Værdi == 5;
            }

            public override void Skriv()
            {
                if (this.ErStjerne())
                    Console.WriteLine("[S]");
                else
                if (this.ErGlobus())
                    Console.WriteLine("[G]");
                else
                    base.Skriv();
            }
        }
    }
}
