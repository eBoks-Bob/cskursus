using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoEgenOpggave
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.ForNavn = "Jan";
            p1.EfterNavn = "Jensen";
            Console.WriteLine(p1.FuldNavn);

            Person p2 = new Person();
            p2.ForNavn = "Henrik";
            p2.EfterNavn = "Nielsen";
            Console.WriteLine(p2.FuldNavn);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press and key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    class Person
    {
        public string ForNavn { get; set; }

        private string efterNavn;

        public string EfterNavn
        {
            get { return efterNavn; }
            set
            {
                if (value.Length < 3)
                    efterNavn = "";
                else
                    efterNavn = value;
            }
        }

        public string FuldNavn
        {
            get
            {
                return ForNavn + " " + EfterNavn;
            }
        }
    }   
}
