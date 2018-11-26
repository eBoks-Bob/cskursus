using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArvOpgave
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            p1.Fornavn = "Jan";
            p1.Efternavn = "Henriksen";
            Console.WriteLine(p1.FuldtNavn());

            Elev e1 = new Elev();
            e1.Fornavn = "Jens";
            e1.Efternavn = "Olesen";
            e1.Klasselokale = "Lokale 1.25";
            Console.WriteLine(e1.FuldtNavn());

            Instrutør i1 = new Instrutør();
            i1.Fornavn = "Ib";
            i1.Efternavn = "Nielsen";
            i1.NøgleId = 25;
            Console.WriteLine(i1.FuldtNavn());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . .");
                Console.ReadKey();
            }
        }
    }

    class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public string FuldtNavn()
        {
            return this.Fornavn + " " + this.Efternavn;
        }
    }
    
    class Elev : Person
    {
        public string Klasselokale { get; set; }
    }

    class Instrutør : Person
    {
        public int NøgleId { get; set; }
    }
}
