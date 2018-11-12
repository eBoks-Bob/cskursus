using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassOpgave
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            p1.fornavn = "Jan";
            p1.efternavn = "Hansen";
            p1.fødselsår = 1951;
            Console.WriteLine(p1.FuldNavn());
            Console.WriteLine(p1.Alder());

            Person p2 = new Person("Jens", "Anderssen", 1968);
            Console.WriteLine(p2.FuldNavn());
            Console.WriteLine(p2.Alder());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . .");
                Console.ReadKey();
            }
        }
    }

    class Person
    {
        public string fornavn;
        public string efternavn;
        public int fødselsår;

        public Person()
        {
            this.fornavn = "";
            this.efternavn = "";
        }

        public Person (string fornavn, string efternavn, int fødselsår)
        {
            this.fornavn = fornavn;
            this.efternavn = efternavn;
            this.fødselsår = fødselsår;
        }

        public string FuldNavn()
        {
            return (fornavn + " " + efternavn);
        }

        public int Alder()
        {
            int år = DateTime.Now.Year;
            return år - this.fødselsår;
        }
    } 
}
