using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new PersonNuGetPackage.PersonRepositoryRandom();
            var people = r.GetPeople(100);
            foreach (var person in people)
                Console.WriteLine(person.Name);

            var res1 = people.OrderBy(i => i.Name); 
            foreach (var person in res1)
                Console.WriteLine(person.Name);

            var res2 = people.OrderBy(i => i.Gender).ThenBy (i=> i.Name);
            foreach (var person in res2)
                Console.WriteLine(person.Name + " " + person.Gender);

            var res3 = people.Where(i => i.Height < 170);
            foreach (var person in res3)
                Console.WriteLine(person.Name + " " + person.Height);

            var res4 = people.Where(i => i.Height < 170 && i.IsHealthy);
            foreach (var person in res4)
                Console.WriteLine(person.Name + " " + person.Height + " " + person.IsHealthy);

            var res5 = people.GroupBy(i => i.Gender);
            foreach (var group in res5)
            {
                Console.WriteLine(group.Key);
                foreach (var person in group)
                {
                    Console.WriteLine(" => " + person.Name + " " + person.Height );
                }
            }
            


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
