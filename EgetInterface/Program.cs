using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgetInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDbFunktioner> lst = new List<IDbFunktioner>();

        }
    }

    class Hund : IDbFunktioner
    {
        public string Navn { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer Hund"); 
        }
    }

    class Ubåd : IDbFunktioner
    {
        public int Nummer { get; set; }
        public double Tubine { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer Ubåd");
        }
    }

    interface IDbFunktioner
    {
        void Gem();
    }
}
