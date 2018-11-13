using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleListOpg
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> lst1 = new List<Person>();
            lst1.Add(new Person() { Id = 1, Navn = "Jens" });
            lst1.Add(new Person() { Id = 2, Navn = "Erik" });
            lst1.Add(new Person() { Id = 3, Navn = "Hans" });

            foreach (var item in lst1)
            {
                Console.WriteLine(item.Id + " " + item.Navn);
            }

            Dictionary<int, Person> lst2 = new Dictionary<int, Person>();
            lst2.Add(1, new Person() { Id = 1, Navn = "Hanne" });
            lst2.Add(2, new Person() { Id = 2, Navn = "Trine" });
            lst2.Add(3, new Person() { Id = 3, Navn = "Lena" });

            var p = lst2[3];
            Console.WriteLine(p.Navn);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . .");
                Console.ReadKey();
            }
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Navn { get; set; }
    }
}
